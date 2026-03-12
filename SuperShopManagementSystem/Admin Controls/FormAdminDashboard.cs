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
    public partial class FormAdminDashboard : Form
    {
        private FormLogin Fl {  get; set; }
        private string AdminName {  get; set; }
        private string AdminId {  get; set; }
        public FormAdminDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        public FormAdminDashboard(string adminId, string adminName, FormLogin fl):this()
        {
            this.AdminId = adminId;
            this.AdminName = adminName;
            this.Fl = fl;
            this.lblAdminName.Text = adminName;
        }

        private void btnManageShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormManageShop(AdminId, this).Show();
        }

        private void btnManageManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormManageManager(AdminId, this).Show();
        }

        private void btnCheckCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAdminCheckCustomer(this).Show();
        }

        private void btnInvoiceDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAdminInvoiceDashboard(this).Show();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAdminUpdatePassword(AdminId,Fl,this).Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fl.Show();
        }

        private void FormAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAdminDashboard_Resize(object sender, EventArgs e)
        {
            panelContainer.Left = (this.ClientSize.Width - panelContainer.Width) / 2;
            panelContainer.Top = (this.ClientSize.Height - panelContainer.Height) / 2;
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
            FormAdminDashboard_Resize(null, null);
        }
    }
}
