using SuperShopManagementSystem.Employees_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagementSystem
{
    public partial class FormEmployeeDashboard : Form
    {
        private FormLogin Fl {  get; set; }
        private string EmployeeName { get; set; }
        private string EmployeeId { get; set; }
        public FormEmployeeDashboard()
        {
            InitializeComponent();
        }

        public FormEmployeeDashboard(string employeeId, string employeeName, FormLogin fl):this()
        {
            this.EmployeeName = employeeName;
            this.EmployeeId = employeeId;
            this.Fl = fl;
            this.lblWelcome.Text += employeeName;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Fl.Show();
            this.Hide();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormEmployeeUpdatePassword(EmployeeId, Fl, this).Show();
        }

        private void FormEmployeeDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormEmployeeDashboard_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormSalesDashboard(EmployeeId, EmployeeName, this).Show();
        } 
    }
}
