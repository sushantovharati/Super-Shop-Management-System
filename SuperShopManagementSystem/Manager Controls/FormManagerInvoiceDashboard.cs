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

namespace SuperShopManagementSystem
{
    public partial class FormManagerInvoiceDashboard : Form
    {
        private FormManagerDashboard Fm {  get; set; }
        private DataAccess Da { get; set; }

        public FormManagerInvoiceDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormManagerInvoiceDashboard(FormManagerDashboard fm):this()
        {
            this.Fm = fm;
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
            this.Fm.Show();
            this.Hide();
        }

        private void FormManagerInvoiceDashboard_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormManagerInvoiceDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
