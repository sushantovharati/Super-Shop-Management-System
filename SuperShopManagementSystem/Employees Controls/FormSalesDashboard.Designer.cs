namespace SuperShopManagementSystem
{
    partial class FormSalesDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpBillingDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutoSearchByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutoSearchById = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.rdCard = new System.Windows.Forms.RadioButton();
            this.rdCash = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustomerPhoneNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvProductInfo = new System.Windows.Forms.DataGridView();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regular_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderList_Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderList_Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderList_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderList_Regular_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderList_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderList_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Dashboard";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(555, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 23);
            this.label13.TabIndex = 5;
            this.label13.Text = "Product List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dtpBillingDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAutoSearchByName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAutoSearchById);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 63);
            this.panel2.TabIndex = 1;
            // 
            // dtpBillingDate
            // 
            this.dtpBillingDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBillingDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBillingDate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillingDate.Location = new System.Drawing.Point(908, 25);
            this.dtpBillingDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpBillingDate.Name = "dtpBillingDate";
            this.dtpBillingDate.Size = new System.Drawing.Size(214, 27);
            this.dtpBillingDate.TabIndex = 49;
            this.dtpBillingDate.Value = new System.DateTime(2025, 1, 15, 1, 15, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search By Name";
            // 
            // txtAutoSearchByName
            // 
            this.txtAutoSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearchByName.Location = new System.Drawing.Point(303, 27);
            this.txtAutoSearchByName.Name = "txtAutoSearchByName";
            this.txtAutoSearchByName.Size = new System.Drawing.Size(206, 28);
            this.txtAutoSearchByName.TabIndex = 2;
            this.txtAutoSearchByName.TextChanged += new System.EventHandler(this.txtAutoSearchByName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search By ID";
            // 
            // txtAutoSearchById
            // 
            this.txtAutoSearchById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearchById.Location = new System.Drawing.Point(51, 27);
            this.txtAutoSearchById.Name = "txtAutoSearchById";
            this.txtAutoSearchById.Size = new System.Drawing.Size(206, 28);
            this.txtAutoSearchById.TabIndex = 0;
            this.txtAutoSearchById.TextChanged += new System.EventHandler(this.txtAutoSearchById_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dgvOrderList);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.dgvProductInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 613);
            this.panel3.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(726, 569);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 43);
            this.btnRemove.TabIndex = 50;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.txtCustomerEmail);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtInvoiceId);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblTK);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnPlaceOrder);
            this.panel4.Controls.Add(this.rdCard);
            this.panel4.Controls.Add(this.rdCash);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtCustomerPhoneNo);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtQuantity);
            this.panel4.Controls.Add(this.txtCustomerName);
            this.panel4.Location = new System.Drawing.Point(882, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 606);
            this.panel4.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 57;
            this.label12.Text = "(Optional)";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "(Optional)";
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceId.Enabled = false;
            this.txtInvoiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceId.Location = new System.Drawing.Point(171, 172);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.ReadOnly = true;
            this.txtInvoiceId.Size = new System.Drawing.Size(206, 28);
            this.txtInvoiceId.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 54;
            this.label10.Text = "Invoice ID";
            // 
            // lblTK
            // 
            this.lblTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.Location = new System.Drawing.Point(159, 129);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(56, 21);
            this.lblTK.TabIndex = 53;
            this.lblTK.Text = "00 TK";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 21);
            this.label9.TabIndex = 52;
            this.label9.Text = "Total Price: ";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Honeydew;
            this.btnPlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(163, 432);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(206, 44);
            this.btnPlaceOrder.TabIndex = 50;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // rdCard
            // 
            this.rdCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdCard.AutoSize = true;
            this.rdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCard.Location = new System.Drawing.Point(266, 388);
            this.rdCard.Name = "rdCard";
            this.rdCard.Size = new System.Drawing.Size(66, 24);
            this.rdCard.TabIndex = 51;
            this.rdCard.TabStop = true;
            this.rdCard.Text = "Card";
            this.rdCard.UseVisualStyleBackColor = true;
            // 
            // rdCash
            // 
            this.rdCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdCash.AutoSize = true;
            this.rdCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCash.Location = new System.Drawing.Point(183, 388);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(69, 24);
            this.rdCash.TabIndex = 50;
            this.rdCash.TabStop = true;
            this.rdCash.Text = "Cash";
            this.rdCash.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "Payment Method";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone Number";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(131, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 58);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustomerPhoneNo
            // 
            this.txtCustomerPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhoneNo.Location = new System.Drawing.Point(171, 277);
            this.txtCustomerPhoneNo.Name = "txtCustomerPhoneNo";
            this.txtCustomerPhoneNo.Size = new System.Drawing.Size(206, 28);
            this.txtCustomerPhoneNo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Customer Name";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(27, 39);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(93, 28);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Text = "1";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(171, 222);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(206, 28);
            this.txtCustomerName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ordered Product";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderList_Product_ID,
            this.OrderList_Product_Name,
            this.OrderList_Category,
            this.OrderList_Regular_Price,
            this.OrderList_Quantity,
            this.OrderList_Total});
            this.dgvOrderList.Location = new System.Drawing.Point(7, 327);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 24;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(869, 236);
            this.dgvOrderList.TabIndex = 47;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.Honeydew;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(7, 569);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 37);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvProductInfo
            // 
            this.dgvProductInfo.AllowUserToAddRows = false;
            this.dgvProductInfo.AllowUserToDeleteRows = false;
            this.dgvProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Id,
            this.Product_Name,
            this.Product_Category,
            this.Product_Quantity,
            this.Regular_Price,
            this.Product_Description});
            this.dgvProductInfo.Location = new System.Drawing.Point(3, 6);
            this.dgvProductInfo.Name = "dgvProductInfo";
            this.dgvProductInfo.ReadOnly = true;
            this.dgvProductInfo.RowHeadersWidth = 51;
            this.dgvProductInfo.RowTemplate.Height = 24;
            this.dgvProductInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductInfo.Size = new System.Drawing.Size(873, 272);
            this.dgvProductInfo.TabIndex = 1;
            // 
            // Product_Id
            // 
            this.Product_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Product_Id.DataPropertyName = "Product_ID";
            this.Product_Id.HeaderText = "Product ID";
            this.Product_Id.MinimumWidth = 6;
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.ReadOnly = true;
            this.Product_Id.Width = 98;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Product_Name.DataPropertyName = "Product_Name";
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.Width = 122;
            // 
            // Product_Category
            // 
            this.Product_Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Category.DataPropertyName = "Product_Category";
            this.Product_Category.HeaderText = "Category";
            this.Product_Category.MinimumWidth = 6;
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.ReadOnly = true;
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Quantity.DataPropertyName = "Product_Quantity";
            this.Product_Quantity.HeaderText = "Available Quantity";
            this.Product_Quantity.MinimumWidth = 6;
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.ReadOnly = true;
            // 
            // Regular_Price
            // 
            this.Regular_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Regular_Price.DataPropertyName = "Regular_Price";
            this.Regular_Price.HeaderText = "Price Per Unit";
            this.Regular_Price.MinimumWidth = 6;
            this.Regular_Price.Name = "Regular_Price";
            this.Regular_Price.ReadOnly = true;
            // 
            // Product_Description
            // 
            this.Product_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Description.DataPropertyName = "Product_Description";
            this.Product_Description.HeaderText = "Description";
            this.Product_Description.MinimumWidth = 6;
            this.Product_Description.Name = "Product_Description";
            this.Product_Description.ReadOnly = true;
            // 
            // OrderList_Product_ID
            // 
            this.OrderList_Product_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderList_Product_ID.DataPropertyName = "Product_ID";
            this.OrderList_Product_ID.HeaderText = "Product ID";
            this.OrderList_Product_ID.MinimumWidth = 6;
            this.OrderList_Product_ID.Name = "OrderList_Product_ID";
            this.OrderList_Product_ID.ReadOnly = true;
            this.OrderList_Product_ID.Width = 98;
            // 
            // OrderList_Product_Name
            // 
            this.OrderList_Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderList_Product_Name.DataPropertyName = "Product_Name";
            this.OrderList_Product_Name.HeaderText = "Product Name";
            this.OrderList_Product_Name.MinimumWidth = 6;
            this.OrderList_Product_Name.Name = "OrderList_Product_Name";
            this.OrderList_Product_Name.ReadOnly = true;
            this.OrderList_Product_Name.Width = 122;
            // 
            // OrderList_Category
            // 
            this.OrderList_Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderList_Category.DataPropertyName = "Product_Category";
            this.OrderList_Category.HeaderText = "Category";
            this.OrderList_Category.MinimumWidth = 6;
            this.OrderList_Category.Name = "OrderList_Category";
            this.OrderList_Category.ReadOnly = true;
            // 
            // OrderList_Regular_Price
            // 
            this.OrderList_Regular_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderList_Regular_Price.DataPropertyName = "Regular_Price";
            this.OrderList_Regular_Price.HeaderText = "Price Per Unit";
            this.OrderList_Regular_Price.MinimumWidth = 6;
            this.OrderList_Regular_Price.Name = "OrderList_Regular_Price";
            this.OrderList_Regular_Price.ReadOnly = true;
            // 
            // OrderList_Quantity
            // 
            this.OrderList_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderList_Quantity.DataPropertyName = "Quantity";
            this.OrderList_Quantity.HeaderText = "Quantity";
            this.OrderList_Quantity.MinimumWidth = 6;
            this.OrderList_Quantity.Name = "OrderList_Quantity";
            this.OrderList_Quantity.ReadOnly = true;
            // 
            // OrderList_Total
            // 
            this.OrderList_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderList_Total.DataPropertyName = "Total";
            this.OrderList_Total.HeaderText = "Sub Total Price";
            this.OrderList_Total.MinimumWidth = 6;
            this.OrderList_Total.Name = "OrderList_Total";
            this.OrderList_Total.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 60;
            this.label14.Text = "(Optional)";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 21);
            this.label15.TabIndex = 59;
            this.label15.Text = "Customer Email";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(171, 333);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(206, 28);
            this.txtCustomerEmail.TabIndex = 58;
            // 
            // FormSalesDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1282, 752);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSalesDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSalesDashboard_FormClosed);
            this.Load += new System.EventHandler(this.FormSalesDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutoSearchById;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutoSearchByName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProductInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerPhoneNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.RadioButton rdCard;
        private System.Windows.Forms.RadioButton rdCash;
        private System.Windows.Forms.DateTimePicker dtpBillingDate;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderList_Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderList_Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderList_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderList_Regular_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderList_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderList_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regular_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Description;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustomerEmail;
    }
}