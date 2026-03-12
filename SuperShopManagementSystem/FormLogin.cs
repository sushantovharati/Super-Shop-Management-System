using iTextSharp.xmp.impl;
using Oracle.ManagedDataAccess.Client;
using SuperShopManagementSystem.Admin_Controls;
using SuperShopManagementSystem.Manager_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace SuperShopManagementSystem
{
    public partial class FormLogin : Form
    {
        private DataAccess Da { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }

        private void ckbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPassword.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill User Id and Password to continue");
                    return;
                }

                string email = txtUserId.Text.Trim();
                string pass = txtPassword.Text;

                string sql = @"SELECT user_type, user_id, user_name FROM (

                SELECT 'ADMIN' AS user_type, Admin_Id AS user_id, Admin_Name AS user_name FROM Admin WHERE Admin_Email = :email AND Admin_Password = :pass

                UNION ALL

                SELECT 'MANAGER' AS user_type, Manager_Id AS user_id, Manager_Name AS user_name FROM Manager WHERE Manager_Email = :email AND Manager_Password = :pass

                UNION ALL

                SELECT 'EMPLOYEE' AS user_type, Employee_Id AS user_id, Employee_Name AS user_name FROM Employee_Manager WHERE Employee_Email = :email AND Employee_Password = :pass
                
                )";

                OracleParameter[] prms =
                {
                    new OracleParameter("email", email),
                    new OracleParameter("pass", pass)
                };

                DataTable dt = Da.ExecuteQueryTable(sql, prms);

                if (dt.Rows.Count == 1)
                {
                    string type = dt.Rows[0]["user_type"].ToString();
                    string id = dt.Rows[0]["user_id"].ToString();
                    string name = dt.Rows[0]["user_name"].ToString();

                    if (type == "ADMIN")
                        new FormAdminDashboard(id, name, this).Show();
                    else if (type == "MANAGER")
                        new FormManagerDashboard(id, name, this).Show();
                    else
                        new FormEmployeeDashboard(id, name, this).Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
