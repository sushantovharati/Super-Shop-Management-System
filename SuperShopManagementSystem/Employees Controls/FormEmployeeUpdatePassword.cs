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

namespace SuperShopManagementSystem.Employees_Controls
{
    public partial class FormEmployeeUpdatePassword : Form
    {
        private FormLogin Fl {  get; set; }
        private FormEmployeeDashboard Fe {  get; set; }
        private string EmployeeId { get; set; }
        private DataAccess Da { get; set; }

        public FormEmployeeUpdatePassword()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public FormEmployeeUpdatePassword(string empId, FormLogin fl, FormEmployeeDashboard fe ) :this()
        {
            this.EmployeeId = empId;
            this.Fl = fl;
            this.Fe = fe;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fe.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtOldPassword.Text) ||
                    string.IsNullOrWhiteSpace(this.txtNewPassword.Text) ||
                    string.IsNullOrWhiteSpace(this.txtConfirmPassword.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                if (this.txtNewPassword.Text != this.txtConfirmPassword.Text)
                {
                    MessageBox.Show("New password and confirm password do not match.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(this.EmployeeId))
                {
                    MessageBox.Show("Employee ID not found. Please login again.");
                    return;
                }

                int empId = Convert.ToInt32(this.EmployeeId);

                // old password check
                string sqlCheck = @"SELECT Employee_ID FROM Employee_Manager WHERE Employee_ID = :idVal AND Employee_Password = :oldPass";

                OracleParameter[] checkParams =
                {
                    new OracleParameter("idVal", empId),
                    new OracleParameter("oldPass", this.txtOldPassword.Text)
                };

                DataTable dt = this.Da.ExecuteQueryTable(sqlCheck, checkParams);

                if (dt.Rows.Count != 1)
                {
                    MessageBox.Show("Old password is incorrect.");
                    return;
                }

                // update new password
                string sqlUpdate = @"UPDATE Employee_Manager SET Employee_Password = :newPass WHERE Employee_ID = :idVal";

                OracleParameter[] updateParams =
                {
                    new OracleParameter("newPass", this.txtNewPassword.Text),
                    new OracleParameter("idVal", empId)
                };

                int count = this.Da.ExecuteDMLQuery(sqlUpdate, updateParams);

                MessageBox.Show(count == 1 ? "Password updated successfully." : "Password update failed.");

                this.txtOldPassword.Clear();
                this.txtNewPassword.Clear();
                this.txtConfirmPassword.Clear();

                this.Fl.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormEmployeeUpdatePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormEmployeeUpdatePassword_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
