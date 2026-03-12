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

namespace SuperShopManagementSystem.Admin_Controls
{
    public partial class FormManageEmployee : Form
    {
        private FormManagerDashboard Fm {  get; set; }
        private int ManagerId { get; set; }
        private DataAccess Da { get; set; }

        public FormManageEmployee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.Da = new DataAccess();
            PopulateGridView();
        }

        public FormManageEmployee(string managerId, FormManagerDashboard fm):this()
        {
            this.ManagerId = Convert.ToInt32(managerId);
            this.Fm = fm;
        }

        private void PopulateGridView(string sql = "SELECT * FROM Employee_Manager ORDER BY Employee_ID ASC")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                dgvEmployeeInfo.AutoGenerateColumns = false;
                dgvEmployeeInfo.DataSource = dt;
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

                int employeeId = Convert.ToInt32(txtId.Text);

                DataTable dt = this.Da.ExecuteQueryTable(
                    "SELECT * FROM Employee_Manager WHERE Employee_ID = :id",
                    new OracleParameter[] { new OracleParameter("id", employeeId) }
                );

                if (dt.Rows.Count == 1)
                {
                    string sqlUpdate = @"UPDATE Employee_Manager
                             SET Employee_Name = :name,
                                 Employee_Email = :email,
                                 Employee_Phone_No_1 = :phone1,
                                 Employee_Phone_No_2 = :phone2,
                                 Employee_Gender = :gender,
                                 Employee_Joining_Date = :joinDate,
                                 Employee_Salary = :salary,
                                 Employee_DoB = :dob,
                                 Employee_NID_No = :nid,
                                 Employee_Password = :password,
                                 Employee_Address = :address,
                                 Manager_ID = :manager
                             WHERE Employee_ID = :id";

                    OracleParameter[] updateParams =
                    {
                        new OracleParameter("name", txtFullName.Text),
                        new OracleParameter("email", txtEmail.Text),
                        new OracleParameter("phone1", txtPhoneNo1.Text),
                        new OracleParameter("phone2", txtPhoneNo2.Text),
                        new OracleParameter("gender", cmbGender.Text),
                        new OracleParameter("joinDate", dtpJoiningDate.Value.Date),
                        new OracleParameter("salary", Convert.ToDecimal(txtSalary.Text)),
                        new OracleParameter("dob", dtpDoB.Value.Date),
                        new OracleParameter("nid", txtNID.Text),
                        new OracleParameter("password", txtPassword.Text),
                        new OracleParameter("address", txtAddress.Text),
                        new OracleParameter("manager", Convert.ToInt32(ManagerId)),
                        new OracleParameter("id", employeeId)
                    };

                    int count = this.Da.ExecuteDMLQuery(sqlUpdate, updateParams);
                    MessageBox.Show(count == 1 ? "Employee updated successfully" : "Update failed");
                }
                else
                {
                    string sqlInsert = @"INSERT INTO Employee_Manager(
                                Employee_ID,
                                Employee_Name,
                                Employee_Email,
                                Employee_Phone_No_1,
                                Employee_Phone_No_2,
                                Employee_Gender,
                                Employee_Joining_Date,
                                Employee_Salary,
                                Employee_DoB,
                                Employee_NID_No,
                                Employee_Password,
                                Employee_Address,
                                Manager_ID)
                             VALUES (
                                :id, :name, :email, :phone1, :phone2,
                                :gender, :joinDate, :salary, :dob,
                                :nid, :password, :address, :manager)";

                    OracleParameter[] insertParams =
                    {
                        new OracleParameter("id", employeeId),
                        new OracleParameter("name", txtFullName.Text),
                        new OracleParameter("email", txtEmail.Text),
                        new OracleParameter("phone1", txtPhoneNo1.Text),
                        new OracleParameter("phone2", txtPhoneNo2.Text),
                        new OracleParameter("gender", cmbGender.Text),
                        new OracleParameter("joinDate", dtpJoiningDate.Value.Date),
                        new OracleParameter("salary", Convert.ToDecimal(txtSalary.Text)),
                        new OracleParameter("dob", dtpDoB.Value.Date),
                        new OracleParameter("nid", txtNID.Text),
                        new OracleParameter("password", txtPassword.Text),
                        new OracleParameter("address", txtAddress.Text),
                        new OracleParameter("manager", Convert.ToInt32(ManagerId))
                    };

                    int count = this.Da.ExecuteDMLQuery(sqlInsert, insertParams);
                    MessageBox.Show(count == 1 ? "Employee added successfully" : "Insert failed");
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
                     || ManagerId<=0);
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

            dgvEmployeeInfo.ClearSelection();
            AutoIdGenerate();
        }

        private void AutoIdGenerate()
        {
            var dt = this.Da.ExecuteQueryTable("SELECT MAX(Employee_ID) FROM Employee_Manager");
            int oldId = dt.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[0][0]);
            txtId.Text = (oldId + 1).ToString();
        }
        private void FormManageEmployee_Load(object sender, EventArgs e)
        {
            dgvEmployeeInfo.ClearSelection();
            AutoIdGenerate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmployeeInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select an employee first to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int employeeId = Convert.ToInt32(this.dgvEmployeeInfo.CurrentRow.Cells["Employee_ID"].Value);
                string employeeName = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Name"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{employeeName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                string sql = "DELETE FROM Employee_Manager WHERE Employee_ID = :id";

                OracleParameter[] param =
                {
        new OracleParameter("id", employeeId)
    };

                int count = this.Da.ExecuteDMLQuery(sql, param);

                if (count == 1)
                    MessageBox.Show("Employee deleted successfully.");
                else
                    MessageBox.Show("Employee deletion failed.");

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
            if (this.dgvEmployeeInfo.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select an employee first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.txtId.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_ID"].Value.ToString();
            this.txtFullName.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Name"].Value.ToString();
            this.txtPhoneNo1.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Phone_No_1"].Value.ToString();
            this.txtPhoneNo2.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Phone_No_2"].Value.ToString();
            this.txtEmail.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Email"].Value.ToString();
            this.cmbGender.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Gender"].Value.ToString();
            this.dtpJoiningDate.Value = Convert.ToDateTime(this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Joining_Date"].Value);
            this.dtpDoB.Value = Convert.ToDateTime(this.dgvEmployeeInfo.CurrentRow.Cells["Employee_DoB"].Value);
            this.txtNID.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_NID_No"].Value.ToString();
            this.txtAddress.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Address"].Value.ToString();
            this.txtSalary.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Salary"].Value.ToString();
            this.txtPassword.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Password"].Value.ToString();

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

            if (!int.TryParse(txtAutoSearchById.Text.Trim(), out int employeeId))
                return;

            string sql = "SELECT * FROM Employee_Manager WHERE Employee_ID = :id";

            OracleParameter[] param =
            {
    new OracleParameter("id", employeeId)
};

            DataTable dt = this.Da.ExecuteQueryTable(sql, param);

            dgvEmployeeInfo.AutoGenerateColumns = false;
            dgvEmployeeInfo.DataSource = dt;

        }

        private void txtAutoSearchByName_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Employee_Manager WHERE LOWER(Employee_Name) LIKE :name";

            OracleParameter[] param =
            {
    new OracleParameter("name", "%" + this.txtAutoSearchByName.Text.ToLower() + "%")
};

            DataTable dt = this.Da.ExecuteQueryTable(sql, param);

            dgvEmployeeInfo.AutoGenerateColumns = false;
            dgvEmployeeInfo.DataSource = dt;

        }

        private void FormManageEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvEmployeeInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvEmployeeInfo.CurrentRow == null)
                return;

            this.txtId.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_ID"].Value.ToString();
            this.txtFullName.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Name"].Value.ToString();
            this.txtPhoneNo1.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Phone_No_1"].Value.ToString();
            this.txtPhoneNo2.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Phone_No_2"].Value.ToString();
            this.txtEmail.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Email"].Value.ToString();
            this.cmbGender.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Gender"].Value.ToString();
            this.dtpJoiningDate.Value = Convert.ToDateTime(this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Joining_Date"].Value);
            this.dtpDoB.Value = Convert.ToDateTime(this.dgvEmployeeInfo.CurrentRow.Cells["Employee_DoB"].Value);
            this.txtNID.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_NID_No"].Value.ToString();
            this.txtAddress.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Address"].Value.ToString();
            this.txtSalary.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Salary"].Value.ToString();
            this.txtPassword.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Password"].Value.ToString();

        }

        private void dgvEmployeeInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvEmployeeInfo.CurrentRow == null)
                return;

            this.txtId.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_ID"].Value.ToString();
            this.txtFullName.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Name"].Value.ToString();
            this.txtPhoneNo1.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Phone_No_1"].Value.ToString();
            this.txtPhoneNo2.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Phone_No_2"].Value.ToString();
            this.txtEmail.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Email"].Value.ToString();
            this.cmbGender.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Gender"].Value.ToString();
            this.dtpJoiningDate.Value = Convert.ToDateTime(this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Joining_Date"].Value);
            this.dtpDoB.Value = Convert.ToDateTime(this.dgvEmployeeInfo.CurrentRow.Cells["Employee_DoB"].Value);
            this.txtNID.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_NID_No"].Value.ToString();
            this.txtAddress.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Address"].Value.ToString();
            this.txtSalary.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Salary"].Value.ToString();
            this.txtPassword.Text = this.dgvEmployeeInfo.CurrentRow.Cells["Employee_Password"].Value.ToString();
            
        }
    }
}
