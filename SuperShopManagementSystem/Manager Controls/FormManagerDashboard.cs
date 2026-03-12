using SuperShopManagementSystem.Admin_Controls;
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
    public partial class FormManagerDashboard : Form
    {
        private FormLogin Fl { get; set; }
        private string ManagerName { get; set; }
        private string ManagerId { get; set; }
        public FormManagerDashboard()
        {
            InitializeComponent();
        }

        public FormManagerDashboard(string managerId, string managerName, FormLogin fl):this()
        {
            this.ManagerId = managerId;
            this.ManagerName = managerName;
            this.Fl = fl;
            this.lblManagerName.Text = managerName;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormManageEmployee(ManagerId, this).Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fl.Show();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormManageProduct(ManagerId, this).Show();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormManagerUpdatePassword(ManagerId, Fl, this).Show();
        }

        private void FormManagerDashboard_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormManagerCheckCustomer(this).Show();
        }

        private void btnInvoiceDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormManagerInvoiceDashboard(this).Show();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void FormManagerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
