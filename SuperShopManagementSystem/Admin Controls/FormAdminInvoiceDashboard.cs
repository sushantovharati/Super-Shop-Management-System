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
    public partial class FormAdminInvoiceDashboard : Form
    {
        private FormAdminDashboard Fa { get; set; }
        private DataAccess Da { get; set; }

        public FormAdminInvoiceDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormAdminInvoiceDashboard(FormAdminDashboard fl) : this()
        {
            this.Fa = fl;
        }

        private void PopulateGridView(string sql = "SELECT * FROM Sales_Order_By_Employee ORDER BY Sales_ID ASC")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                dgvInvoice.AutoGenerateColumns = false;
                dgvInvoice.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fa.Show();
        }

        private void FormAdminInvoiceDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAdminInvoiceDashboard_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
