using iTextSharp.text;
using iTextSharp.text.pdf;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SuperShopManagementSystem
{
    public partial class FormSalesDashboard : Form
    {
        private DataAccess Da { get; set; }
        private FormEmployeeDashboard Fe { get; set; }
        public string ProductId { get; set; }
        public int OldQuantity { get; set; }
        public int NewQuantity { get; set; }
        private string EmployeeName { get; set; }
        private string CustomerName { get; set; } = "-";
        private string CustomerPhoneNo { get; set; } = "-";
        private float TotalPrice { get; set; }
        public string PaymentMethod { get; set; }
        private string EmployeeId {  get; set; }

        public FormSalesDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            this.WindowState = FormWindowState.Maximized;
        }

        public FormSalesDashboard(string employeeId, string employeeName, FormEmployeeDashboard fe):this()
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.Fe = fe;
        }

        private void PopulateGridView(string sql = "SELECT * FROM Product ORDER BY Product_ID ASC")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                dgvProductInfo.AutoGenerateColumns = false;
                dgvProductInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AutoIdGenerate()
        {
            var dt = this.Da.ExecuteQueryTable("SELECT MAX(Sales_ID) FROM Sales_Order_By_Employee ");
            int oldId = dt.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[0][0]);
            txtInvoiceId.Text = (oldId + 1).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductInfo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a product first.");
                    return;
                }

                if (string.IsNullOrEmpty(txtQuantity.Text) || int.Parse(txtQuantity.Text) <= 0)
                {
                    MessageBox.Show("Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.ProductId = dgvProductInfo.CurrentRow.Cells["Product_ID"].Value.ToString();
                this.OldQuantity = int.Parse(dgvProductInfo.CurrentRow.Cells["Product_Quantity"].Value.ToString());
                int quantityToAdd = int.Parse(txtQuantity.Text);

                if (OldQuantity <= 0 || OldQuantity < quantityToAdd)
                {
                    MessageBox.Show(OldQuantity <= 0 ? "Out of Stock" : "Insufficient Stock", "Error");
                    return;
                }

                this.NewQuantity = OldQuantity - quantityToAdd;

                var sql = @"UPDATE Product SET Product_Quantity = :qty WHERE Product_ID = :id";
                OracleParameter[] param =
                {
                    new OracleParameter("qty", this.NewQuantity),
                    new OracleParameter("id", Convert.ToInt32(this.ProductId))
                };

                this.Da.ExecuteDMLQuery(sql, param);
                this.ShowOrderList();
                this.PopulateGridView();
                this.dgvProductInfo.ClearSelection();
                this.CalculateTotalPrice();
                this.txtQuantity.Text = "1";
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something Went Wrong. Error: " + exc.Message);
            }
        }


        private void FormSalesDashboard_Load(object sender, EventArgs e)
        {
            dgvProductInfo.ClearSelection();
            AutoIdGenerate();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrderList.CurrentRow == null || dgvOrderList.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Please select a product to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string productId = dgvOrderList.CurrentRow.Cells["OrderList_Product_ID"].Value.ToString();
                int removedQuantity = int.Parse(dgvOrderList.CurrentRow.Cells["OrderList_Quantity"].Value.ToString());

                foreach (DataGridViewRow row in dgvProductInfo.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["Product_ID"].Value.ToString() == productId)
                    {
                        int currentQuantity = int.Parse(row.Cells["Product_Quantity"].Value.ToString());
                        int newQuantity = currentQuantity + removedQuantity;

                        string updateProductQuery = "UPDATE Product SET Product_Quantity = :qty WHERE Product_ID = :id";

                        OracleParameter[] param =
                        {
                            new OracleParameter("qty", newQuantity),
                            new OracleParameter("id", Convert.ToInt32(productId))
                        };

                        int rowsAffected = this.Da.ExecuteDMLQuery(updateProductQuery, param);

                        if (rowsAffected > 0)
                        {
                            dgvOrderList.Rows.Remove(dgvOrderList.CurrentRow);
                            this.CalculateTotalPrice();
                            this.PopulateGridView();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update product quantity in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while removing the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Clear()
        {
            this.txtCustomerName.Clear();
            this.txtCustomerPhoneNo.Clear();
            this.txtCustomerEmail.Clear();
            this.rdCard.Checked = this.rdCash.Checked = false;
            this.AutoIdGenerate();
        }

        private void GenerateBill()
        {
            if (rdCash.Checked)
            {
                this.PaymentMethod = rdCash.Text;
            }
            else if (rdCard.Checked)
            {
                this.PaymentMethod = rdCard.Text;
            }

            this.CustomerName = txtCustomerName.Text;
            this.CustomerPhoneNo = txtCustomerPhoneNo.Text;

            Document document = new Document();
            PdfWriter.GetInstance(
                document,
                new FileStream(
                    @"C:\Users\User\Desktop\ADMS Project\SuperShopManagementSystem\Bill PDF\"
                    + this.txtInvoiceId.Text + ".pdf",
                    FileMode.Create
                )

            );

            document.Open();

            Paragraph pTitle = new Paragraph("Invoice Id : " + this.txtInvoiceId.Text + "\n\n");
            Paragraph p1 = new Paragraph(
                "Customer Name : " + this.CustomerName + "\n\n" +
                "Customer Phone Number : " + this.CustomerPhoneNo + "\n\n" +
                "Payment Method : " + this.PaymentMethod + "\n\n" +
                "Date : " + dtpBillingDate.Text + "\n\n" +
                "Sales-man : " + this.EmployeeName + "\n\n"
            );
            Paragraph p3 = new Paragraph("Product Name - Quantity - Total Price\n\n");

            document.Add(pTitle);
            document.Add(p1);
            document.Add(p3);

            foreach (DataGridViewRow row in this.dgvOrderList.Rows)
            {
                if (row.IsNewRow) continue;

                string productName = row.Cells["OrderList_Product_Name"].Value.ToString();
                string quantity = row.Cells["OrderList_Quantity"].Value.ToString();
                string price = row.Cells["OrderList_Total"].Value.ToString();

                document.Add(new Paragraph(productName + ": " + quantity + ": " + price));
            }

            Paragraph p5 = new Paragraph("\n\nTotal Price : " + this.TotalPrice + " TK");
            Paragraph p6 = new Paragraph("=============================== PAID ===================================");

            document.Add(p5);
            document.Add(p6);
            document.Close();

            MessageBox.Show("Order Confirmed!\n\n Payment Successfull");
        }

        private void CalculateTotalPrice()
        {
            float total = 0;

            foreach (DataGridViewRow row in dgvOrderList.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["OrderList_Regular_Price"].Value != null &&
                    row.Cells["OrderList_Quantity"].Value != null)
                {
                    float price = float.Parse(row.Cells["OrderList_Regular_Price"].Value.ToString());
                    int quantity = int.Parse(row.Cells["OrderList_Quantity"].Value.ToString());

                    total += price * quantity;
                }
            }

            this.TotalPrice = total;
            lblTK.Text = total + " TK";
        }

        private void ShowOrderList()
        {
            string productId = this.dgvProductInfo.CurrentRow.Cells["Product_ID"].Value.ToString();
            float pricePerUnit = float.Parse(this.dgvProductInfo.CurrentRow.Cells["Regular_Price"].Value.ToString());

            foreach (DataGridViewRow row in this.dgvOrderList.Rows)
            {
                if (row.Cells["OrderList_Product_ID"].Value != null && row.Cells["OrderList_Product_ID"].Value.ToString() == productId)
                {
                    int existingQuantity = int.Parse(row.Cells["OrderList_Quantity"].Value.ToString());
                    int newQuantity = existingQuantity + int.Parse(this.txtQuantity.Text);
                    row.Cells["OrderList_Quantity"].Value = newQuantity;
                    row.Cells["OrderList_Total"].Value = newQuantity * pricePerUnit;
                    return;
                }
            }

            dgvOrderList.Rows.Add(
                this.dgvProductInfo.CurrentRow.Cells["Product_ID"].Value,
                this.dgvProductInfo.CurrentRow.Cells["Product_Name"].Value,
                this.dgvProductInfo.CurrentRow.Cells["Product_Category"].Value,
                this.dgvProductInfo.CurrentRow.Cells["Regular_Price"].Value,
                this.txtQuantity.Text,
                int.Parse(this.txtQuantity.Text) * pricePerUnit
            );
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(rdCash.Checked || rdCard.Checked))
                {
                    MessageBox.Show("Please Select Payment Method.");
                    return;
                }

                var sql = @"SELECT NVL(Total_Purchase_Amount,0) AS Total_Purchase_Amount
            FROM Customer
            WHERE Customer_Phone_Number_1 = :phone";


                OracleParameter[] param = 
                {
                    new OracleParameter("phone", this.txtCustomerPhoneNo.Text)
                };

                DataTable dt = this.Da.ExecuteQueryTable(sql, param);

                bool customerExists = dt.Rows.Count > 0;

                if (dt.Rows.Count > 0)
                {
                    int previousAmount = 0;
                    int newTotal = 0;
                    string customerStatus;

                    previousAmount =  Convert.ToInt32(dt.Rows[0]["Total_Purchase_Amount"]);

                    newTotal = previousAmount + Convert.ToInt32(this.TotalPrice);

                    if (newTotal > 20000) customerStatus = "Platinum";
                    else if (newTotal >= 10000 && newTotal <= 20000) customerStatus = "Gold";
                    else customerStatus = "Silver";

                    var sqlUpdate = @"UPDATE Customer SET Total_Purchase_Amount = :newTotal, Membership_Type = :status WHERE Customer_Phone_Number_1 = :phone";

                    OracleParameter[] paramUpdate =
                     {
                        new OracleParameter("newTotal", newTotal),
                        new OracleParameter("status", customerStatus),
                        new OracleParameter("phone", this.txtCustomerPhoneNo.Text)
                     };

                    this.Da.ExecuteDMLQuery(sqlUpdate, paramUpdate);

                }
                else
                {

                    var sqlMaxId = @"SELECT NVL(MAX(Customer_ID), 0) AS MaxId FROM Customer";

                    DataTable dtMax = this.Da.ExecuteQueryTable(sqlMaxId);

                    int newCustomerId = Convert.ToInt32(dtMax.Rows[0]["MaxId"]) + 1;

                    decimal newTotal = Convert.ToInt32(this.TotalPrice);
                    string customerStatus;

                    if (newTotal > 20000) customerStatus = "Platinum";
                    else if (newTotal >= 10000) customerStatus = "Gold";
                    else customerStatus = "Silver";


                    var sqlInsert = @"INSERT INTO Customer (Customer_ID, Customer_Name, Customer_Email, Customer_Phone_Number_1, Membership_Type, Total_Purchase_Amount)
                                    VALUES
                                    (:custId, :custName, :custEmail, :phone, :status, :amount)";

                    OracleParameter[] paramInsert =
                    {
                        new OracleParameter("custId", newCustomerId),

                        new OracleParameter(
                            "custName",
                            string.IsNullOrWhiteSpace(this.txtCustomerName.Text)
                                ? "-"
                                : this.txtCustomerName.Text
                        ),

                        new OracleParameter(
                            "custEmail",
                            string.IsNullOrWhiteSpace(this.txtCustomerEmail.Text)
                                ? "-"
                                : this.txtCustomerEmail.Text
                        ),

                        new OracleParameter("phone", this.txtCustomerPhoneNo.Text),

                        new OracleParameter("status", customerStatus),

                        new OracleParameter("amount", newTotal)
                    };

                    this.Da.ExecuteDMLQuery(sqlInsert, paramInsert);

                }

                PaymentMethod = rdCash.Checked ? "Cash" : "Card";

                var sqlInvoice = @"INSERT INTO Sales_Order_By_Employee (Sales_ID, Sales_Order_Date, Sales_Amount, Sales_Payment, Employee_ID)
                                VALUES (:salesId, :orderDate, :amount, :payment, :empId)";

                OracleParameter[] paramInvoice =
                {
                    new OracleParameter("salesId", this.txtInvoiceId.Text),          // Sales_ID
                    new OracleParameter("orderDate", this.dtpBillingDate.Value.Date),// Sales_Order_Date
                    new OracleParameter("amount", this.TotalPrice),                  // Sales_Amount
                    new OracleParameter("payment", this.PaymentMethod),              // Sales_Payment
                    new OracleParameter("empId", this.EmployeeId)                     // Employee_ID
                };

                int count = this.Da.ExecuteDMLQuery(sqlInvoice, paramInvoice);


                if (count > 0)
                {
                    this.GenerateBill();
                    this.dgvOrderList.Rows.Clear();
                    this.Clear();
                }
                else
                {
                    MessageBox.Show("Payment Unsuccessful. Try Again.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong." + exc);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fe.Show();
        }

        private void txtAutoSearchByName_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Product WHERE LOWER(Product_Name) LIKE :name";

            OracleParameter[] param =
            {
                new OracleParameter("name", "%" + this.txtAutoSearchByName.Text.ToLower() + "%")
            };

            DataTable dt = this.Da.ExecuteQueryTable(sql, param);

            dgvProductInfo.AutoGenerateColumns = false;
            dgvProductInfo.DataSource = dt;
        }

        private void txtAutoSearchById_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAutoSearchById.Text))
            {
                PopulateGridView();
                return;
            }

            if (!int.TryParse(txtAutoSearchById.Text.Trim(), out int productId))
                return;

            string sql = "SELECT * FROM Product WHERE Product_ID = :id";

            OracleParameter[] param =
            {
                new OracleParameter("id", productId)
            };

            DataTable dt = this.Da.ExecuteQueryTable(sql, param);

            dgvProductInfo.AutoGenerateColumns = false;
            dgvProductInfo.DataSource = dt;
        }

        private void FormSalesDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
