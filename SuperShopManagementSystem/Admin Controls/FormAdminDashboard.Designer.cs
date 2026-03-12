namespace SuperShopManagementSystem.Admin_Controls
{
    partial class FormAdminDashboard
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
            this.lblAdminName = new System.Windows.Forms.Label();
            this.btnCheckCustomers = new System.Windows.Forms.Button();
            this.btnInvoiceDashboard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnManageManager = new System.Windows.Forms.Button();
            this.btnManageShop = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.panelContainer.Controls.Add(this.lblAdminName);
            this.panelContainer.Controls.Add(this.btnCheckCustomers);
            this.panelContainer.Controls.Add(this.btnInvoiceDashboard);
            this.panelContainer.Controls.Add(this.btnLogout);
            this.panelContainer.Controls.Add(this.btnUpdatePassword);
            this.panelContainer.Controls.Add(this.btnManageManager);
            this.panelContainer.Controls.Add(this.btnManageShop);
            this.panelContainer.Controls.Add(this.lblWelcome);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1282, 753);
            this.panelContainer.TabIndex = 1;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(538, 81);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(330, 59);
            this.lblAdminName.TabIndex = 8;
            this.lblAdminName.Text = "Admin_Name";
            // 
            // btnCheckCustomers
            // 
            this.btnCheckCustomers.BackColor = System.Drawing.Color.Honeydew;
            this.btnCheckCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckCustomers.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCustomers.Location = new System.Drawing.Point(402, 348);
            this.btnCheckCustomers.Name = "btnCheckCustomers";
            this.btnCheckCustomers.Size = new System.Drawing.Size(448, 57);
            this.btnCheckCustomers.TabIndex = 7;
            this.btnCheckCustomers.Text = "Check Customers";
            this.btnCheckCustomers.UseVisualStyleBackColor = false;
            this.btnCheckCustomers.Click += new System.EventHandler(this.btnCheckCustomers_Click);
            // 
            // btnInvoiceDashboard
            // 
            this.btnInvoiceDashboard.BackColor = System.Drawing.Color.Honeydew;
            this.btnInvoiceDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoiceDashboard.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceDashboard.Location = new System.Drawing.Point(402, 431);
            this.btnInvoiceDashboard.Name = "btnInvoiceDashboard";
            this.btnInvoiceDashboard.Size = new System.Drawing.Size(448, 57);
            this.btnInvoiceDashboard.TabIndex = 5;
            this.btnInvoiceDashboard.Text = "Invoice Dashboard";
            this.btnInvoiceDashboard.UseVisualStyleBackColor = false;
            this.btnInvoiceDashboard.Click += new System.EventHandler(this.btnInvoiceDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Honeydew;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(402, 607);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(448, 57);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BackColor = System.Drawing.Color.Honeydew;
            this.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(402, 519);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(448, 57);
            this.btnUpdatePassword.TabIndex = 3;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // btnManageManager
            // 
            this.btnManageManager.BackColor = System.Drawing.Color.Honeydew;
            this.btnManageManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageManager.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageManager.Location = new System.Drawing.Point(402, 262);
            this.btnManageManager.Name = "btnManageManager";
            this.btnManageManager.Size = new System.Drawing.Size(448, 57);
            this.btnManageManager.TabIndex = 2;
            this.btnManageManager.Text = "Manage Managers";
            this.btnManageManager.UseVisualStyleBackColor = false;
            this.btnManageManager.Click += new System.EventHandler(this.btnManageManager_Click);
            // 
            // btnManageShop
            // 
            this.btnManageShop.BackColor = System.Drawing.Color.Honeydew;
            this.btnManageShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageShop.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageShop.Location = new System.Drawing.Point(402, 174);
            this.btnManageShop.Name = "btnManageShop";
            this.btnManageShop.Size = new System.Drawing.Size(448, 57);
            this.btnManageShop.TabIndex = 1;
            this.btnManageShop.Text = "Manage Shops";
            this.btnManageShop.UseVisualStyleBackColor = false;
            this.btnManageShop.Click += new System.EventHandler(this.btnManageShop_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(306, 81);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(246, 59);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome ";
            // 
            // FormAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.panelContainer);
            this.Name = "FormAdminDashboard";
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.FormAdminDashboard_Load);
            this.Resize += new System.EventHandler(this.FormAdminDashboard_Resize);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnInvoiceDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnManageManager;
        private System.Windows.Forms.Button btnManageShop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCheckCustomers;
        private System.Windows.Forms.Label lblAdminName;
    }
}