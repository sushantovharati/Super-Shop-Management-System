namespace SuperShopManagementSystem.Admin_Controls
{
    partial class FormManageShop
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvShopInfo = new System.Windows.Forms.DataGridView();
            this.Shop_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop_Phone_No_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop_Phone_No_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtShopPhoneNo2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtShopLocation = new System.Windows.Forms.TextBox();
            this.txtShopEmail = new System.Windows.Forms.TextBox();
            this.txtShopPhoneNo1 = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShopId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(155, 543);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 45);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Honeydew;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(333, 322);
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
            this.btnBack.Location = new System.Drawing.Point(14, 626);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 37);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Shop Name";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txtAutoSearch);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtSearchById);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.dgvShopInfo);
            this.panel5.Location = new System.Drawing.Point(470, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(812, 660);
            this.panel5.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(600, 47);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 16);
            this.label13.TabIndex = 75;
            this.label13.Text = "* Double click on any row to update.";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.Location = new System.Drawing.Point(319, 33);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(219, 27);
            this.txtAutoSearch.TabIndex = 67;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(315, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 20);
            this.label15.TabIndex = 66;
            this.label15.Text = "Search by Shop Name";
            // 
            // txtSearchById
            // 
            this.txtSearchById.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchById.Location = new System.Drawing.Point(23, 34);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(167, 27);
            this.txtSearchById.TabIndex = 64;
            this.txtSearchById.TextChanged += new System.EventHandler(this.txtSearchById_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 20);
            this.label14.TabIndex = 63;
            this.label14.Text = "Search by Shop ID";
            // 
            // dgvShopInfo
            // 
            this.dgvShopInfo.AllowUserToAddRows = false;
            this.dgvShopInfo.AllowUserToDeleteRows = false;
            this.dgvShopInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShopInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShopInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Shop_Id,
            this.Shop_Name,
            this.Shop_Phone_No_1,
            this.Shop_Phone_No_2,
            this.Shop_Email,
            this.Shop_Location});
            this.dgvShopInfo.Location = new System.Drawing.Point(-1, 69);
            this.dgvShopInfo.Name = "dgvShopInfo";
            this.dgvShopInfo.ReadOnly = true;
            this.dgvShopInfo.RowHeadersWidth = 51;
            this.dgvShopInfo.RowTemplate.Height = 24;
            this.dgvShopInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShopInfo.Size = new System.Drawing.Size(812, 590);
            this.dgvShopInfo.TabIndex = 1;
            this.dgvShopInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShopInfo_CellContentDoubleClick);
            // 
            // Shop_Id
            // 
            this.Shop_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Shop_Id.DataPropertyName = "Shop_Id";
            this.Shop_Id.HeaderText = "Shop ID";
            this.Shop_Id.MinimumWidth = 6;
            this.Shop_Id.Name = "Shop_Id";
            this.Shop_Id.ReadOnly = true;
            this.Shop_Id.Width = 78;
            // 
            // Shop_Name
            // 
            this.Shop_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shop_Name.DataPropertyName = "Shop_Name";
            this.Shop_Name.HeaderText = "Shop Name";
            this.Shop_Name.MinimumWidth = 6;
            this.Shop_Name.Name = "Shop_Name";
            this.Shop_Name.ReadOnly = true;
            // 
            // Shop_Phone_No_1
            // 
            this.Shop_Phone_No_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shop_Phone_No_1.DataPropertyName = "Shop_Phone_No_1";
            this.Shop_Phone_No_1.HeaderText = "Shop Phone No 1";
            this.Shop_Phone_No_1.MinimumWidth = 6;
            this.Shop_Phone_No_1.Name = "Shop_Phone_No_1";
            this.Shop_Phone_No_1.ReadOnly = true;
            // 
            // Shop_Phone_No_2
            // 
            this.Shop_Phone_No_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shop_Phone_No_2.DataPropertyName = "Shop_Phone_No_2";
            this.Shop_Phone_No_2.HeaderText = "Shop Phone No 2";
            this.Shop_Phone_No_2.MinimumWidth = 6;
            this.Shop_Phone_No_2.Name = "Shop_Phone_No_2";
            this.Shop_Phone_No_2.ReadOnly = true;
            // 
            // Shop_Email
            // 
            this.Shop_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shop_Email.DataPropertyName = "Shop_Email";
            this.Shop_Email.HeaderText = "Shop Email";
            this.Shop_Email.MinimumWidth = 6;
            this.Shop_Email.Name = "Shop_Email";
            this.Shop_Email.ReadOnly = true;
            // 
            // Shop_Location
            // 
            this.Shop_Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shop_Location.DataPropertyName = "Shop_Location";
            this.Shop_Location.HeaderText = "Shop Location";
            this.Shop_Location.MinimumWidth = 6;
            this.Shop_Location.Name = "Shop_Location";
            this.Shop_Location.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 670);
            this.panel3.TabIndex = 28;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(14, 543);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 45);
            this.btnRemove.TabIndex = 60;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.panel4.Controls.Add(this.txtShopPhoneNo2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.txtShopLocation);
            this.panel4.Controls.Add(this.txtShopEmail);
            this.panel4.Controls.Add(this.txtShopPhoneNo1);
            this.panel4.Controls.Add(this.txtShopName);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtShopId);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(470, 670);
            this.panel4.TabIndex = 29;
            // 
            // txtShopPhoneNo2
            // 
            this.txtShopPhoneNo2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopPhoneNo2.Location = new System.Drawing.Point(234, 160);
            this.txtShopPhoneNo2.Name = "txtShopPhoneNo2";
            this.txtShopPhoneNo2.Size = new System.Drawing.Size(214, 27);
            this.txtShopPhoneNo2.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 27);
            this.label5.TabIndex = 61;
            this.label5.Text = "Shop Phone No 2";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(280, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 45);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtShopLocation
            // 
            this.txtShopLocation.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopLocation.Location = new System.Drawing.Point(234, 269);
            this.txtShopLocation.Name = "txtShopLocation";
            this.txtShopLocation.Size = new System.Drawing.Size(214, 27);
            this.txtShopLocation.TabIndex = 42;
            // 
            // txtShopEmail
            // 
            this.txtShopEmail.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopEmail.Location = new System.Drawing.Point(234, 211);
            this.txtShopEmail.Name = "txtShopEmail";
            this.txtShopEmail.Size = new System.Drawing.Size(214, 27);
            this.txtShopEmail.TabIndex = 40;
            // 
            // txtShopPhoneNo1
            // 
            this.txtShopPhoneNo1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopPhoneNo1.Location = new System.Drawing.Point(234, 108);
            this.txtShopPhoneNo1.Name = "txtShopPhoneNo1";
            this.txtShopPhoneNo1.Size = new System.Drawing.Size(214, 27);
            this.txtShopPhoneNo1.TabIndex = 39;
            // 
            // txtShopName
            // 
            this.txtShopName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopName.Location = new System.Drawing.Point(234, 59);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(214, 27);
            this.txtShopName.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 27);
            this.label11.TabIndex = 37;
            this.label11.Text = "Shop Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Shop Phone No 1";
            // 
            // txtShopId
            // 
            this.txtShopId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtShopId.Enabled = false;
            this.txtShopId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopId.Location = new System.Drawing.Point(234, 11);
            this.txtShopId.Name = "txtShopId";
            this.txtShopId.ReadOnly = true;
            this.txtShopId.Size = new System.Drawing.Size(214, 27);
            this.txtShopId.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "Shop ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
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
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shop Information";
            // 
            // FormManageShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.panel1);
            this.Name = "FormManageShop";
            this.Text = "FormManageShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageShop_FormClosed);
            this.Load += new System.EventHandler(this.FormManageShop_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvShopInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtShopLocation;
        private System.Windows.Forms.TextBox txtShopEmail;
        private System.Windows.Forms.TextBox txtShopPhoneNo1;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShopId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop_Phone_No_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop_Phone_No_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop_Location;
        private System.Windows.Forms.TextBox txtShopPhoneNo2;
        private System.Windows.Forms.Label label5;
    }
}