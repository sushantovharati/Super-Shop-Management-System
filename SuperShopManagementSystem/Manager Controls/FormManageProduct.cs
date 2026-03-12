using Oracle.ManagedDataAccess.Client;
using SuperShopManagementSystem.Manager_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SuperShopManagementSystem.Admin_Controls
{
    public partial class FormManageProduct : Form
    {
        private DataAccess Da {  get; set; }
        private FormManagerDashboard Fm { get; set; }
        private string ManagerId {  get; set; }

        public FormManageProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        public FormManageProduct(string managerId,FormManagerDashboard fm):this()
        {
            this.Fm = fm;
            this.ManagerId = managerId;
        }

        private void PopulateGridView(string sql = "SELECT * FROM Product ORDER BY Product_ID ASC")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                dgvProductInfo.AutoGenerateColumns = false;
                dgvProductInfo.DataSource = dt;
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

                int product_id = Convert.ToInt32(txtProductId.Text);

                DataTable dt = this.Da.ExecuteQueryTable(
                    "SELECT * FROM Product WHERE Product_ID = :id",
                    new OracleParameter[] { new OracleParameter("id", product_id) }
                );

                if (dt.Rows.Count == 1)
                {
                    string sqlUpdate = @"UPDATE Product
                             SET Product_Name = :name,
                                 Product_Description = :description,
                                 Product_Quantity = :quantity,
                                 Product_Category = :category,
                                 Regular_Price = :price,
                                 Manager_ID = :manager
                             WHERE Product_ID = :id";

                    OracleParameter[] updateParams =
                    {
                        new OracleParameter("name", txtProductName.Text),
                        new OracleParameter("description", txtDescription.Text),
                        new OracleParameter("quantity", Convert.ToInt32(txtQuantity.Text)),
                        new OracleParameter("category", cmbCategory.Text),
                        new OracleParameter("price", Convert.ToDecimal(txtRegularPrice.Text)),
                        new OracleParameter("manager", Convert.ToInt32(ManagerId)),
                        new OracleParameter("id", product_id)
                    };

                    int count = this.Da.ExecuteDMLQuery(sqlUpdate, updateParams);
                    MessageBox.Show(count == 1 ? "Product updated successfully" : "Update failed");
                }
                else
                {
                    string sqlInsert = @"INSERT INTO Product(
                                Product_ID,
                                Product_Name,
                                Product_Description,
                                Product_Quantity,
                                Product_Category,
                                Regular_Price,
                                Manager_ID)
                             VALUES (:id, :name, :description, :quantity, :category, :price, :manager)";

                    OracleParameter[] insertParams =
                    {
                        new OracleParameter("id", product_id),
                        new OracleParameter("name", txtProductName.Text),
                        new OracleParameter("description", txtDescription.Text),
                        new OracleParameter("quantity", Convert.ToInt32(txtQuantity.Text)),
                        new OracleParameter("category", cmbCategory.Text),
                        new OracleParameter("price", Convert.ToDecimal(txtRegularPrice.Text)),
                        new OracleParameter("manager", Convert.ToInt32(ManagerId))
                    };

                    int count = this.Da.ExecuteDMLQuery(sqlInsert, insertParams);
                    MessageBox.Show(count == 1 ? "Product added successfully" : "Insert failed");
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
            return !(string.IsNullOrWhiteSpace(txtProductId.Text)
                     || string.IsNullOrWhiteSpace(txtProductName.Text)
                     || string.IsNullOrWhiteSpace(txtDescription.Text)
                     || string.IsNullOrWhiteSpace(txtQuantity.Text)
                     || string.IsNullOrWhiteSpace(cmbCategory.Text)
                     || string.IsNullOrWhiteSpace(txtRegularPrice.Text)
                     || string.IsNullOrWhiteSpace(ManagerId));
        }

        private void ClearAll()
        {
            this.txtProductId.Clear();
            this.txtProductName.Clear();
            this.txtDescription.Clear();
            this.txtQuantity.Clear();
            this.cmbCategory.SelectedIndex = -1;
            this.txtRegularPrice.Clear();

            dgvProductInfo.ClearSelection();
            AutoIdGenerate();
        }

        private void AutoIdGenerate()
        {
            var dt = this.Da.ExecuteQueryTable("SELECT MAX(Product_ID) FROM Product");
            int oldId = dt.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[0][0]);
            txtProductId.Text = (oldId + 1).ToString();
        }


        private void dgvProductInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormManageProduct_Load(object sender, EventArgs e)
        {
            dgvProductInfo.ClearSelection();
            AutoIdGenerate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvProductInfo.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a product first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.txtProductId.Text = this.dgvProductInfo.CurrentRow.Cells["Product_ID"].Value.ToString();
            this.txtProductName.Text = this.dgvProductInfo.CurrentRow.Cells["Product_Name"].Value.ToString();
            this.txtDescription.Text = this.dgvProductInfo.CurrentRow.Cells["Product_Description"].Value.ToString();
            this.txtQuantity.Text = this.dgvProductInfo.CurrentRow.Cells["Product_Quantity"].Value.ToString();
            this.cmbCategory.Text = this.dgvProductInfo.CurrentRow.Cells["Product_Category"].Value.ToString();
            this.txtRegularPrice.Text = this.dgvProductInfo.CurrentRow.Cells["Regular_Price"].Value.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProductInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a product first to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productId = Convert.ToInt32(this.dgvProductInfo.CurrentRow.Cells["Product_ID"].Value);
                string productName = this.dgvProductInfo.CurrentRow.Cells["Product_Name"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{productName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                string sql = "DELETE FROM Product WHERE Product_ID = :id";

                OracleParameter[] param =
                {
        new OracleParameter("id", productId)
    };

                int count = this.Da.ExecuteDMLQuery(sql, param);

                if (count == 1)
                    MessageBox.Show("Product deleted successfully.");
                else
                    MessageBox.Show("Product deletion failed.");

                PopulateGridView();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtAutoSearchById_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAutoSearchById.Text))
            {
                PopulateGridView();
                return;
            }

            if (!int.TryParse(txtAutoSearchById.Text.Trim(), out int productId))
                return;

            string sql = "SELECT * FROM Product WHERE Product_ID = :id";

            OracleParameter[] param =
            {
    new OracleParameter("id", productId)
};

            DataTable dt = this.Da.ExecuteQueryTable(sql, param);

            dgvProductInfo.AutoGenerateColumns = false;
            dgvProductInfo.DataSource = dt;

        }

        private void txtAutoSearchByName_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Product WHERE LOWER(Product_Name) LIKE :name";

            OracleParameter[] param =
            {
    new OracleParameter("name", "%" + this.txtAutoSearchByName.Text.ToLower() + "%")
};

            DataTable dt = this.Da.ExecuteQueryTable(sql, param);

            dgvProductInfo.AutoGenerateColumns = false;
            dgvProductInfo.DataSource = dt;

        }

        private void FormManageProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvProductInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProductInfo.CurrentRow == null)
                return;

            this.txtProductId.Text = this.dgvProductInfo.CurrentRow.Cells["Product_ID"].Value.ToString();
            this.txtProductName.Text = this.dgvProductInfo.CurrentRow.Cells["Product_Name"].Value.ToString();
            this.txtDescription.Text = this.dgvProductInfo.CurrentRow.Cells["Product_Description"].Value.ToString();
            this.txtQuantity.Text = this.dgvProductInfo.CurrentRow.Cells["Product_Quantity"].Value.ToString();
            this.cmbCategory.Text = this.dgvProductInfo.CurrentRow.Cells["Product_Category"].Value.ToString();
            this.txtRegularPrice.Text = this.dgvProductInfo.CurrentRow.Cells["Regular_Price"].Value.ToString();

        }

        private void dgvProductInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProductInfo.CurrentRow == null)
                return;

            this.txtProductId.Text =
                this.dgvProductInfo.CurrentRow.Cells["Product_ID"].Value.ToString();

            this.txtProductName.Text =
                this.dgvProductInfo.CurrentRow.Cells["Product_Name"].Value.ToString();

            this.txtDescription.Text =
                this.dgvProductInfo.CurrentRow.Cells["Product_Description"].Value.ToString();

            this.txtQuantity.Text =
                this.dgvProductInfo.CurrentRow.Cells["Product_Quantity"].Value.ToString();

            this.cmbCategory.Text =
                this.dgvProductInfo.CurrentRow.Cells["Product_Category"].Value.ToString();

            this.txtRegularPrice.Text =
                this.dgvProductInfo.CurrentRow.Cells["Regular_Price"].Value.ToString();

        }
    }
}
