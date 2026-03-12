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

namespace SuperShopManagementSystem.Manager_Controls
{
    public partial class FormManagerUpdatePassword : Form
    {
        private FormLogin Fl {  get; set; }
        private FormManagerDashboard Fm { get; set; }
        private DataAccess Da { get; set; }
        private string ManagerId { get; set; }

        public FormManagerUpdatePassword()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public FormManagerUpdatePassword(string managerId, FormLogin fl, FormManagerDashboard fm):this()
        {
            this.ManagerId = managerId;
            this.Fl = fl;
            this.Fm = fm;
        }

        private void FormManagerUpdatePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

                int mgrId = Convert.ToInt32(this.ManagerId);

                // 1) old password check
                string sqlCheck = @"SELECT Manager_ID FROM Manager WHERE Manager_ID = :idVal AND Manager_Password = :oldPass";

                OracleParameter[] checkParams =
                {
                    new OracleParameter("idVal", mgrId),
                    new OracleParameter("oldPass", this.txtOldPassword.Text)
                };

                DataTable dt = this.Da.ExecuteQueryTable(sqlCheck, checkParams);

                if (dt.Rows.Count != 1)
                {
                    MessageBox.Show("Old password is incorrect.");
                    return;
                }

                // 2) update new password
                string sqlUpdate = @"UPDATE Manager SET Manager_Password = :newPass WHERE Manager_ID = :idVal";

                OracleParameter[] updateParams =
                {
                    new OracleParameter("newPass", this.txtNewPassword.Text),
                    new OracleParameter("idVal", mgrId)
                };

                int count = this.Da.ExecuteDMLQuery(sqlUpdate, updateParams);

                MessageBox.Show(count == 1 ? "Password updated successfully." : "Password update failed.");

                this.txtOldPassword.Clear();
                this.txtNewPassword.Clear();
                this.txtConfirmPassword.Clear();

                this.Hide();
                this.Fl.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Fm.Show();
            this.Hide(); 
        }

        private void FormManagerUpdatePassword_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
