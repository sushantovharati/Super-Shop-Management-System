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
    public partial class FormAdminCheckCustomer : Form
    {

        private FormAdminDashboard Fa { get; set; }
        private DataAccess Da { get; set; }

        public FormAdminCheckCustomer()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        public FormAdminCheckCustomer(FormAdminDashboard fa) : this()
        {
            this.Fa = fa;
        }

        private void PopulateGridView(string sql = "SELECT * FROM Customer ORDER BY Customer_ID ASC")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                dgvCustomerInfo.AutoGenerateColumns = false;
                dgvCustomerInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Fa.Show();
            this.Hide();
        }

        private void FormAdminCheckCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
