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
    public partial class FormManagerCheckCustomer : Form
    {
        private FormManagerDashboard Fm {  get; set; }
        private DataAccess Da { get; set; }

        public FormManagerCheckCustomer()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormManagerCheckCustomer(FormManagerDashboard fm):this()
        {
            this.Fm = fm;
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
        private void FormManagerCheckCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fm.Show();
        }
    }
}
