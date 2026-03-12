namespace SuperShopManagementSystem.Manager_Controls
{
    partial class FormManagerCheckCustomer
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCustomerInfo = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Phone_Number_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membership_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Controls.Add(this.btnBack);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Location = new System.Drawing.Point(0, -1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1283, 754);
            this.panelContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customers";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.Honeydew;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 705);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 37);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCustomerInfo);
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 616);
            this.panel2.TabIndex = 3;
            // 
            // dgvCustomerInfo
            // 
            this.dgvCustomerInfo.AllowUserToAddRows = false;
            this.dgvCustomerInfo.AllowUserToDeleteRows = false;
            this.dgvCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.Customer_Name,
            this.Customer_Email,
            this.Customer_Phone_Number_1,
            this.Membership_Type});
            this.dgvCustomerInfo.Location = new System.Drawing.Point(0, 3);
            this.dgvCustomerInfo.Name = "dgvCustomerInfo";
            this.dgvCustomerInfo.ReadOnly = true;
            this.dgvCustomerInfo.RowHeadersWidth = 51;
            this.dgvCustomerInfo.RowTemplate.Height = 24;
            this.dgvCustomerInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerInfo.Size = new System.Drawing.Size(1238, 613);
            this.dgvCustomerInfo.TabIndex = 3;
            // 
            // Customer_ID
            // 
            this.Customer_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_ID.DataPropertyName = "Customer_ID";
            this.Customer_ID.HeaderText = "Customer ID";
            this.Customer_ID.MinimumWidth = 6;
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_Name.DataPropertyName = "Customer_Name";
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.MinimumWidth = 6;
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            // 
            // Customer_Email
            // 
            this.Customer_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_Email.DataPropertyName = "Customer_Email";
            this.Customer_Email.HeaderText = "Customer Email";
            this.Customer_Email.MinimumWidth = 6;
            this.Customer_Email.Name = "Customer_Email";
            this.Customer_Email.ReadOnly = true;
            // 
            // Customer_Phone_Number_1
            // 
            this.Customer_Phone_Number_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_Phone_Number_1.DataPropertyName = "Customer_Phone_Number_1";
            this.Customer_Phone_Number_1.HeaderText = "Customer Phone No";
            this.Customer_Phone_Number_1.MinimumWidth = 6;
            this.Customer_Phone_Number_1.Name = "Customer_Phone_Number_1";
            this.Customer_Phone_Number_1.ReadOnly = true;
            // 
            // Membership_Type
            // 
            this.Membership_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Membership_Type.DataPropertyName = "Membership_Type";
            this.Membership_Type.HeaderText = "Membership Status";
            this.Membership_Type.MinimumWidth = 6;
            this.Membership_Type.Name = "Membership_Type";
            this.Membership_Type.ReadOnly = true;
            // 
            // FormManagerCheckCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.panelContainer);
            this.Name = "FormManagerCheckCustomer";
            this.Text = "All Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManagerCheckCustomer_FormClosed);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCustomerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Phone_Number_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membership_Type;
    }
}