namespace SuperShopManagementSystem.Admin_Controls
{
    partial class FormManageProduct
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
            this.label13 = new System.Windows.Forms.Label();
            this.txtAutoSearchByName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAutoSearchById = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtRegularPrice = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvProductInfo = new System.Windows.Forms.DataGridView();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regular_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(606, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 16);
            this.label13.TabIndex = 76;
            this.label13.Text = "* Double click on any row to update.";
            // 
            // txtAutoSearchByName
            // 
            this.txtAutoSearchByName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearchByName.Location = new System.Drawing.Point(310, 33);
            this.txtAutoSearchByName.Name = "txtAutoSearchByName";
            this.txtAutoSearchByName.Size = new System.Drawing.Size(219, 27);
            this.txtAutoSearchByName.TabIndex = 62;
            this.txtAutoSearchByName.TextChanged += new System.EventHandler(this.txtAutoSearchByName_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(306, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 20);
            this.label15.TabIndex = 60;
            this.label15.Text = "Search by Product Name";
            // 
            // txtAutoSearchById
            // 
            this.txtAutoSearchById.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearchById.Location = new System.Drawing.Point(14, 34);
            this.txtAutoSearchById.Name = "txtAutoSearchById";
            this.txtAutoSearchById.Size = new System.Drawing.Size(167, 27);
            this.txtAutoSearchById.TabIndex = 12;
            this.txtAutoSearchById.TextChanged += new System.EventHandler(this.txtAutoSearchById_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Category";
            // 
            // txtProductId
            // 
            this.txtProductId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtProductId.Enabled = false;
            this.txtProductId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(195, 8);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(214, 27);
            this.txtProductId.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "Product ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.txtRegularPrice);
            this.panel4.Controls.Add(this.cmbCategory);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.txtDescription);
            this.panel4.Controls.Add(this.txtQuantity);
            this.panel4.Controls.Add(this.txtProductName);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtProductId);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 670);
            this.panel4.TabIndex = 29;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(14, 547);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 45);
            this.btnRemove.TabIndex = 58;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(155, 547);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 45);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtRegularPrice
            // 
            this.txtRegularPrice.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegularPrice.Location = new System.Drawing.Point(195, 202);
            this.txtRegularPrice.Name = "txtRegularPrice";
            this.txtRegularPrice.Size = new System.Drawing.Size(214, 27);
            this.txtRegularPrice.TabIndex = 55;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Grocery",
            "Dairy",
            "Poultry",
            "Meat",
            "Snacks",
            "Toiletries",
            "Beverage",
            "Household",
            "Electronics",
            "Fish",
            "Frozen"});
            this.cmbCategory.Location = new System.Drawing.Point(195, 103);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(214, 28);
            this.cmbCategory.TabIndex = 53;
            this.cmbCategory.Text = "Select";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Honeydew;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(299, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 31);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.Honeydew;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 621);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 37);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(282, 547);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 45);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(195, 252);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(214, 27);
            this.txtDescription.TabIndex = 43;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(195, 152);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(214, 27);
            this.txtQuantity.TabIndex = 40;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(195, 56);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(214, 27);
            this.txtProductName.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 27);
            this.label11.TabIndex = 37;
            this.label11.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 27);
            this.label10.TabIndex = 36;
            this.label10.Text = "Regular Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Description";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 670);
            this.panel3.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txtAutoSearchByName);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtAutoSearchById);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.dgvProductInfo);
            this.panel5.Location = new System.Drawing.Point(422, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(860, 660);
            this.panel5.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Search by Product ID";
            // 
            // dgvProductInfo
            // 
            this.dgvProductInfo.AllowUserToAddRows = false;
            this.dgvProductInfo.AllowUserToDeleteRows = false;
            this.dgvProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Id,
            this.Product_Name,
            this.Product_Category,
            this.Product_Quantity,
            this.Regular_Price,
            this.Product_Description});
            this.dgvProductInfo.Location = new System.Drawing.Point(-1, 82);
            this.dgvProductInfo.Name = "dgvProductInfo";
            this.dgvProductInfo.ReadOnly = true;
            this.dgvProductInfo.RowHeadersWidth = 51;
            this.dgvProductInfo.RowTemplate.Height = 24;
            this.dgvProductInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductInfo.Size = new System.Drawing.Size(860, 577);
            this.dgvProductInfo.TabIndex = 1;
            this.dgvProductInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductInfo_CellContentClick);
            this.dgvProductInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductInfo_CellContentDoubleClick);
            this.dgvProductInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductInfo_CellDoubleClick);
            // 
            // Product_Id
            // 
            this.Product_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Id.DataPropertyName = "Product_Id";
            this.Product_Id.HeaderText = "Product ID";
            this.Product_Id.MinimumWidth = 6;
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Name.DataPropertyName = "Product_Name";
            this.Product_Name.HeaderText = "Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
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
            this.Product_Quantity.HeaderText = "Quantity";
            this.Product_Quantity.MinimumWidth = 6;
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.ReadOnly = true;
            // 
            // Regular_Price
            // 
            this.Regular_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Regular_Price.DataPropertyName = "Regular_Price";
            this.Regular_Price.HeaderText = "Regular Price";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 753);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 83);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Information";
            // 
            // FormManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.panel1);
            this.Name = "FormManageProduct";
            this.Text = "Manage Product";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageProduct_FormClosed);
            this.Load += new System.EventHandler(this.FormManageProduct_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAutoSearchByName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAutoSearchById;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtRegularPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvProductInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regular_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Description;
    }
}