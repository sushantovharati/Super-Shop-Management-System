using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace SuperShopManagementSystem.Admin_Controls
{
    public partial class FormManageShop : Form
    {
        private DataAccess Da { get; set; }
        private int AdminId { get; set; }
        private FormAdminDashboard Fa { get; set; }

        public FormManageShop()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        public FormManageShop(string adminId, FormAdminDashboard fa) : this()
        {
            this.Fa = fa;
            this.AdminId = Convert.ToInt32(adminId);
        }

        private void PopulateGridView(string sql = "SELECT * FROM Shop_Admin ORDER BY Shop_ID ASC")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                dgvShopInfo.AutoGenerateColumns = false;
                dgvShopInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please fill all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int shop_id = Convert.ToInt32(txtShopId.Text);

                // Check if shop exists
                DataTable dt = this.Da.ExecuteQueryTable("SELECT * FROM Shop_Admin WHERE Shop_ID = :id",
                    new OracleParameter[] { new OracleParameter("id", shop_id) });

                if (dt.Rows.Count == 1)
                {
                    // UPDATE
                    string sqlUpdate = @"UPDATE Shop_Admin
                                         SET Shop_Name = :name,
                                             Shop_Phone_No_1 = :phone1,
                                             Shop_Phone_No_2 = :phone2,
                                             Shop_Email = :email,
                                             Shop_Location = :location,
                                             Admin_ID = :admin
                                         WHERE Shop_ID = :id";

                    OracleParameter[] updateParams = {
                        new OracleParameter("name", txtShopName.Text),
                        new OracleParameter("phone1", txtShopPhoneNo1.Text),
                        new OracleParameter("phone2", txtShopPhoneNo2.Text),
                        new OracleParameter("email", txtShopEmail.Text),
                        new OracleParameter("location", txtShopLocation.Text),
                        new OracleParameter("admin", AdminId),
                        new OracleParameter("id", shop_id)
                    };

                    int count = this.Da.ExecuteDMLQuery(sqlUpdate, updateParams);

                    MessageBox.Show(count == 1 ? "Shop updated successfully" : "Update failed");
                }
                else
                {
                    // INSERT
                    string sqlInsert = @"INSERT INTO Shop_Admin
                                         (Shop_ID, Shop_Name, Shop_Phone_No_1, Shop_Phone_No_2, Shop_Email, Shop_Location, Admin_ID)
                                         VALUES (:id, :name, :phone1, :phone2, :email, :location, :admin)";

                    OracleParameter[] insertParams = {
                        new OracleParameter("id", shop_id),
                        new OracleParameter("name", txtShopName.Text),
                        new OracleParameter("phone1", txtShopPhoneNo1.Text),
                        new OracleParameter("phone2", txtShopPhoneNo2.Text),
                        new OracleParameter("email", txtShopEmail.Text),
                        new OracleParameter("location", txtShopLocation.Text),
                        new OracleParameter("admin", AdminId)
                    };

                    int count = this.Da.ExecuteDMLQuery(sqlInsert, insertParams);

                    MessageBox.Show(count == 1 ? "Shop added successfully" : "Insert failed");
                }

                PopulateGridView();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsValidToSave()
        {
            return !(string.IsNullOrWhiteSpace(txtShopId.Text)
                     || string.IsNullOrWhiteSpace(txtShopName.Text)
                     || string.IsNullOrWhiteSpace(txtShopPhoneNo1.Text)
                     || string.IsNullOrWhiteSpace(txtShopPhoneNo2.Text)
                     || string.IsNullOrWhiteSpace(txtShopEmail.Text)
                     || string.IsNullOrWhiteSpace(txtShopLocation.Text)
                     || AdminId <= 0);
        }

        private void ClearAll()
        {
            txtShopId.Clear();
            txtShopName.Clear();
            txtShopPhoneNo1.Clear();
            txtShopPhoneNo2.Clear();
            txtShopEmail.Clear();
            txtShopLocation.Clear();

            dgvShopInfo.ClearSelection();
            AutoIdGenerate();
        }

        private void AutoIdGenerate()
        {
            var dt = this.Da.ExecuteQueryTable("SELECT MAX(Shop_ID) FROM Shop_Admin");
            int oldId = dt.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[0][0]);
            txtShopId.Text = (oldId + 1).ToString();
        }

        private void FormManageShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fa.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void FormManageShop_Load(object sender, EventArgs e)
        {
            dgvShopInfo.ClearSelection();
            AutoIdGenerate();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Shop_Admin WHERE LOWER(Shop_Name) LIKE :name";

            Oracle.ManagedDataAccess.Client.OracleParameter[] param =
            {
                new Oracle.ManagedDataAccess.Client.OracleParameter("name", "%" + this.txtAutoSearch.Text.ToLower() + "%")
            };

            DataTable dt = this.Da.ExecuteQueryTable(sql, param);

            dgvShopInfo.AutoGenerateColumns = false;
            dgvShopInfo.DataSource = dt;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvShopInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a shop first to remove.",
                                    "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Get selected values safely
                int shopId = Convert.ToInt32(this.dgvShopInfo.CurrentRow.Cells["Shop_ID"].Value);
                string shopName = this.dgvShopInfo.CurrentRow.Cells["Shop_Name"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete '{shopName}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                    return;

                string sql = "DELETE FROM Shop_Admin WHERE Shop_ID = :shopId";

                Oracle.ManagedDataAccess.Client.OracleParameter[] param =
                {
                    new Oracle.ManagedDataAccess.Client.OracleParameter("shopId", shopId)
                };

                int count = this.Da.ExecuteDMLQuery(sql, param);

                if (count == 1)
                    MessageBox.Show("Shop deleted successfully.");
                else
                    MessageBox.Show("Shop deletion failed.");

                PopulateGridView();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvShopInfo.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a shop first.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            this.txtShopId.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_ID"].Value.ToString();

            this.txtShopName.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_Name"].Value.ToString();

            this.txtShopPhoneNo1.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_Phone_No_1"].Value.ToString();

            this.txtShopPhoneNo2.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_Phone_No_2"].Value.ToString();

            this.txtShopEmail.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_Email"].Value.ToString();

            this.txtShopLocation.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_Location"].Value.ToString();
        }

        private void dgvShopInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvShopInfo.CurrentRow == null)
                return;

            this.txtShopId.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_ID"].Value.ToString();

            this.txtShopName.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_Name"].Value.ToString();

            this.txtShopPhoneNo1.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_Phone_No_1"].Value.ToString();

            this.txtShopPhoneNo2.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_Phone_No_2"].Value.ToString();

            this.txtShopEmail.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_Email"].Value.ToString();

            this.txtShopLocation.Text =
                this.dgvShopInfo.CurrentRow.Cells["Shop_Location"].Value.ToString();
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchById.Text))
            {
                PopulateGridView();
                return;
            }

            if (!int.TryParse(txtSearchById.Text.Trim(), out int shopId))
                return;

            string sql = "SELECT * FROM Shop_Admin WHERE Shop_ID = :id";

            OracleParameter[] param =
            {
        new OracleParameter("id", shopId)
    };

            DataTable dt = this.Da.ExecuteQueryTable(sql, param);

            dgvShopInfo.AutoGenerateColumns = false;
            dgvShopInfo.DataSource = dt;
        }
    }
}

