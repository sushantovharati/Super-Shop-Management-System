using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagementSystem.Admin_Controls
{
    public partial class FormManageManager : Form
    {
        private FormAdminDashboard Fa {  get; set; }
        private int AdminId { get; set; }
        private DataAccess Da { get; set; }
        public FormManageManager()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        public FormManageManager(string adminId, FormAdminDashboard fa):this()
        {
            this.Fa = fa;
            this.AdminId = Convert.ToInt32(adminId);
        }

        private void PopulateGridView(string sql = "SELECT * FROM Manager ORDER BY Manager_ID ASC")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                dgvManagerInfo.AutoGenerateColumns = false;
                dgvManagerInfo.DataSource = dt;
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

                int manager_id = Convert.ToInt32(txtId.Text);

                DataTable dt = this.Da.ExecuteQueryTable("SELECT * FROM Manager WHERE Manager_ID = :id",
                    new OracleParameter[] { new OracleParameter("id", manager_id) } );

                if (dt.Rows.Count == 1)
                {
                    string sqlUpdate = @"UPDATE Manager
                                 SET Manager_Name = :name,
                                     Manager_Phone_No_1 = :phone1,
                                     Manager_Phone_No_2 = :phone2,
                                     Manager_Email = :email,
                                     Manager_Gender = :gender,
                                     Manager_DoB = :dob,
                                     Manager_Joining_Date = :joinDate,
                                     Manager_NID_No = :nid,
                                     Manager_Address = :address,
                                     Manager_Salary = :salary,
                                     Manager_Password = :password,
                                     Admin_ID = :admin
                                 WHERE Manager_ID = :id";

                    OracleParameter[] updateParams =
                    {
                        new OracleParameter("name", txtFullName.Text),
                        new OracleParameter("phone1", txtPhoneNo1.Text),
                        new OracleParameter("phone2", txtPhoneNo2.Text),
                        new OracleParameter("email", txtEmail.Text),
                        new OracleParameter("gender", cmbGender.Text),
                        new OracleParameter("dob", dtpDoB.Value.Date),
                        new OracleParameter("joinDate", dtpJoiningDate.Value.Date),
                        new OracleParameter("nid", txtNID.Text),
                        new OracleParameter("address", txtAddress.Text),
                        new OracleParameter("salary", Convert.ToDecimal(txtSalary.Text)),
                        new OracleParameter("password", txtPassword.Text),
                        new OracleParameter("admin", AdminId),
                        new OracleParameter("id", manager_id)
                    };

                    int count = this.Da.ExecuteDMLQuery(sqlUpdate, updateParams);

                    MessageBox.Show(count == 1 ? "Manager updated successfully" : "Update failed");
                }
                else
                {
                    string sqlInsert = @"INSERT INTO Manager(
                                            Manager_ID, 
                                            Manager_Name, 
                                            Manager_Phone_No_1, 
                                            Manager_Phone_No_2, 
                                            Manager_Email,
                                            Manager_Gender, 
                                            Manager_DoB, 
                                            Manager_Joining_Date, 
                                            Manager_NID_No, 
                                            Manager_Address,
                                            Manager_Salary, 
                                            Manager_Password, 
                                            Admin_ID)
                                      VALUES (:id, :name, :phone1, :phone2, :email, :gender, :dob, :joinDate, :nid, :address, :salary, :password, :admin)";

                    OracleParameter[] insertParams =
                    {
                        new OracleParameter("id", manager_id),
                        new OracleParameter("name", txtFullName.Text),
                        new OracleParameter("phone1", txtPhoneNo1.Text),
                        new OracleParameter("phone2", txtPhoneNo2.Text),
                        new OracleParameter("email", txtEmail.Text),
                        new OracleParameter("gender", cmbGender.Text),
                        new OracleParameter("dob", dtpDoB.Value.Date),
                        new OracleParameter("joinDate", dtpJoiningDate.Value.Date),
                        new OracleParameter("nid", txtNID.Text),
                        new OracleParameter("address", txtAddress.Text),
                        new OracleParameter("salary", Convert.ToDecimal(txtSalary.Text)),
                        new OracleParameter("password", txtPassword.Text),
                        new OracleParameter("admin", AdminId)
                    };

                    int count = this.Da.ExecuteDMLQuery(sqlInsert, insertParams);

                    MessageBox.Show(count == 1 ? "Manager added successfully" : "Insert failed");
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
            return !(string.IsNullOrWhiteSpace(txtId.Text)
                     || string.IsNullOrWhiteSpace(txtFullName.Text)
                     || string.IsNullOrWhiteSpace(txtPhoneNo1.Text)
                     || string.IsNullOrWhiteSpace(txtPhoneNo2.Text)
                     || string.IsNullOrWhiteSpace(txtEmail.Text)
                     || string.IsNullOrWhiteSpace(cmbGender.Text)
                     || string.IsNullOrWhiteSpace(txtNID.Text)
                     || string.IsNullOrWhiteSpace(txtAddress.Text)
                     || string.IsNullOrWhiteSpace(txtSalary.Text)
                     || string.IsNullOrWhiteSpace(txtPassword.Text)
                     || AdminId <= 0);
        }

        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtFullName.Clear();
            this.txtPhoneNo1.Clear();
            this.txtPhoneNo2.Clear();
            this.txtEmail.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.dtpDoB.Value = DateTime.Today;
            this.dtpJoiningDate.Value = DateTime.Today;
            this.txtNID.Clear();
            this.txtAddress.Clear();
            this.txtSalary.Clear();
            this.txtPassword.Clear();

            dgvManagerInfo.ClearSelection();
            AutoIdGenerate();
        }

        private void AutoIdGenerate()
        {
            var dt = this.Da.ExecuteQueryTable("SELECT MAX(Manager_ID) FROM Manager");
            int oldId = dt.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[0][0]);
            txtId.Text = (oldId + 1).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvManagerInfo.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a manager first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.txtId.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_ID"].Value.ToString(); 
            this.txtFullName.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Name"].Value.ToString(); 
            this.txtPhoneNo1.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Phone_No_1"].Value.ToString(); 
            this.txtPhoneNo2.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Phone_No_2"].Value.ToString(); 
            this.txtEmail.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Email"].Value.ToString();
            this.cmbGender.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Gender"].Value.ToString();
            this.dtpDoB.Value = Convert.ToDateTime(this.dgvManagerInfo.CurrentRow.Cells["Manager_DoB"].Value); 
            this.dtpJoiningDate.Value = Convert.ToDateTime(this.dgvManagerInfo.CurrentRow.Cells["Manager_Joining_Date"].Value); 
            this.txtNID.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_NID_No"].Value.ToString(); 
            this.txtAddress.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Address"].Value.ToString(); 
            this.txtSalary.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Salary"].Value.ToString(); 
            this.txtPassword.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Password"].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvManagerInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a manager first to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int managerId = Convert.ToInt32(this.dgvManagerInfo.CurrentRow.Cells["Manager_ID"].Value);
                string managerName = this.dgvManagerInfo.CurrentRow.Cells["Manager_Name"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{managerName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                string sql = "DELETE FROM Manager WHERE Manager_ID = :id";

                OracleParameter[] param =
                {
                    new OracleParameter("id", managerId)
                };

                int count = this.Da.ExecuteDMLQuery(sql, param);

                if (count == 1)
                    MessageBox.Show("Manager deleted successfully.");
                else
                    MessageBox.Show("Manager deletion failed.");

                PopulateGridView();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fa.Show();

        }
        private void FormManageManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvManagerInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvManagerInfo.CurrentRow == null)
                return;

            this.txtId.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_ID"].Value.ToString(); 
            this.txtFullName.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Name"].Value.ToString(); 
            this.txtPhoneNo1.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Phone_No_1"].Value.ToString(); 
            this.txtPhoneNo2.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Phone_No_2"].Value.ToString(); 
            this.txtEmail.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Email"].Value.ToString(); 
            this.cmbGender.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Gender"].Value.ToString(); 
            this.dtpDoB.Value = Convert.ToDateTime(this.dgvManagerInfo.CurrentRow.Cells["Manager_DoB"].Value); 
            this.dtpJoiningDate.Value = Convert.ToDateTime(this.dgvManagerInfo.CurrentRow.Cells["Manager_Joining_Date"].Value); 
            this.txtNID.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_NID_No"].Value.ToString(); 
            this.txtAddress.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Address"].Value.ToString(); 
            this.txtSalary.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Salary"].Value.ToString(); 
            this.txtPassword.Text = this.dgvManagerInfo.CurrentRow.Cells["Manager_Password"].Value.ToString();

        }

        private void dgvManagerInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvManagerInfo.CurrentRow == null)
                return;

            this.txtId.Text =
                this.dgvManagerInfo.CurrentRow.Cells["Manager_ID"].Value.ToString();

            this.txtFullName.Text =
                this.dgvManagerInfo.CurrentRow.Cells["Manager_Name"].Value.ToString();

            this.txtPhoneNo1.Text =
                this.dgvManagerInfo.CurrentRow.Cells["Manager_Phone_No_1"].Value.ToString();

            this.txtPhoneNo2.Text =
                this.dgvManagerInfo.CurrentRow.Cells["Manager_Phone_No_2"].Value.ToString();

            this.txtEmail.Text =
                this.dgvManagerInfo.CurrentRow.Cells["Manager_Email"].Value.ToString();

            this.cmbGender.Text =
                this.dgvManagerInfo.CurrentRow.Cells["Manager_Gender"].Value.ToString();

            this.dtpDoB.Value =
                Convert.ToDateTime(this.dgvManagerInfo.CurrentRow.Cells["Manager_DoB"].Value);

            this.dtpJoiningDate.Value =
                Convert.ToDateTime(this.dgvManagerInfo.CurrentRow.Cells["Manager_Joining_Date"].Value);

            this.txtNID.Text =
                this.dgvManagerInfo.CurrentRow.Cells["Manager_NID_No"].Value.ToString();

            this.txtAddress.Text =
                this.dgvManagerInfo.CurrentRow.Cells["Manager_Address"].Value.ToString();

            this.txtSalary.Text =
                this.dgvManagerInfo.CurrentRow.Cells["Manager_Salary"].Value.ToString();

            this.txtPassword.Text =
                this.dgvManagerInfo.CurrentRow.Cells["Manager_Password"].Value.ToString();
        }

        private void FormManageManager_Load(object sender, EventArgs e)
        {
            dgvManagerInfo.ClearSelection();
            AutoIdGenerate();
        }

        private void txtAutoSearchByName_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Manager WHERE LOWER(Manager_Name) LIKE :name";

            OracleParameter[] param =
            {
                new OracleParameter("name", "%" + this.txtAutoSearchByName.Text.ToLower() + "%")
            };

            DataTable dt = this.Da.ExecuteQueryTable(sql, param);

            dgvManagerInfo.AutoGenerateColumns = false;
            dgvManagerInfo.DataSource = dt;
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchById.Text))
            {
                PopulateGridView();
                return;
            }

            if (!int.TryParse(txtSearchById.Text.Trim(), out int managerId))
                return;

            string sql = "SELECT * FROM Manager WHERE Manager_ID = :id";

            OracleParameter[] param =
            {
        new OracleParameter("id", managerId)
    };

            DataTable dt = this.Da.ExecuteQueryTable(sql, param);

            dgvManagerInfo.AutoGenerateColumns = false;
            dgvManagerInfo.DataSource = dt;
        }

    }
}

