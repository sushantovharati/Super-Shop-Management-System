namespace SuperShopManagementSystem
{
    partial class FormManagerInvoiceDashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.Sales_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Order_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 86);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvInvoice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 554);
            this.panel2.TabIndex = 1;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sales_ID,
            this.Sales_Order_Date,
            this.Sales_Amount,
            this.Sales_Payment,
            this.Employee_ID});
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(1282, 554);
            this.dgvInvoice.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 113);
            this.panel3.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.Honeydew;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 64);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 37);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Sales_ID
            // 
            this.Sales_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sales_ID.DataPropertyName = "Sales_ID";
            this.Sales_ID.HeaderText = "Invoice ID";
            this.Sales_ID.MinimumWidth = 6;
            this.Sales_ID.Name = "Sales_ID";
            this.Sales_ID.ReadOnly = true;
            // 
            // Sales_Order_Date
            // 
            this.Sales_Order_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sales_Order_Date.DataPropertyName = "Sales_Order_Date";
            this.Sales_Order_Date.HeaderText = "Sales Order Date";
            this.Sales_Order_Date.MinimumWidth = 6;
            this.Sales_Order_Date.Name = "Sales_Order_Date";
            this.Sales_Order_Date.ReadOnly = true;
            // 
            // Sales_Amount
            // 
            this.Sales_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sales_Amount.DataPropertyName = "Sales_Amount";
            this.Sales_Amount.HeaderText = "Sales Amount";
            this.Sales_Amount.MinimumWidth = 6;
            this.Sales_Amount.Name = "Sales_Amount";
            this.Sales_Amount.ReadOnly = true;
            // 
            // Sales_Payment
            // 
            this.Sales_Payment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sales_Payment.DataPropertyName = "Sales_Payment";
            this.Sales_Payment.HeaderText = "Sales Payment Type";
            this.Sales_Payment.MinimumWidth = 6;
            this.Sales_Payment.Name = "Sales_Payment";
            this.Sales_Payment.ReadOnly = true;
            // 
            // Employee_ID
            // 
            this.Employee_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Employee_ID.DataPropertyName = "Employee_ID";
            this.Employee_ID.HeaderText = "Employee ID";
            this.Employee_ID.MinimumWidth = 6;
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.ReadOnly = true;
            // 
            // FormManagerInvoiceDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormManagerInvoiceDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManagerInvoiceDashboard_FormClosed);
            this.Load += new System.EventHandler(this.FormManagerInvoiceDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Order_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
    }
}