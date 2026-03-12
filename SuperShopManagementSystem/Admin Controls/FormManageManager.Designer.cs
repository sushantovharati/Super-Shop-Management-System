namespace SuperShopManagementSystem.Admin_Controls
{
    partial class FormManageManager
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo1 = new System.Windows.Forms.TextBox();
            this.txtAutoSearchByName = new System.Windows.Forms.TextBox();
            this.dgvManagerInfo = new System.Windows.Forms.DataGridView();
            this.Manager_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Phone_No_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Phone_No_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Joining_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_NID_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPhoneNo2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerInfo)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(315, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 20);
            this.label15.TabIndex = 66;
            this.label15.Text = "Search by Manager Name";
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
            // txtNID
            // 
            this.txtNID.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNID.Location = new System.Drawing.Point(181, 356);
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(214, 27);
            this.txtNID.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manager Information";
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(280, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 45);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(181, 435);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(214, 27);
            this.txtSalary.TabIndex = 43;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(181, 394);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 27);
            this.txtAddress.TabIndex = 42;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(181, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 27);
            this.txtEmail.TabIndex = 40;
            // 
            // txtPhoneNo1
            // 
            this.txtPhoneNo1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo1.Location = new System.Drawing.Point(181, 88);
            this.txtPhoneNo1.Name = "txtPhoneNo1";
            this.txtPhoneNo1.Size = new System.Drawing.Size(214, 27);
            this.txtPhoneNo1.TabIndex = 39;
            // 
            // txtAutoSearchByName
            // 
            this.txtAutoSearchByName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearchByName.Location = new System.Drawing.Point(319, 33);
            this.txtAutoSearchByName.Name = "txtAutoSearchByName";
            this.txtAutoSearchByName.Size = new System.Drawing.Size(219, 27);
            this.txtAutoSearchByName.TabIndex = 67;
            this.txtAutoSearchByName.TextChanged += new System.EventHandler(this.txtAutoSearchByName_TextChanged);
            // 
            // dgvManagerInfo
            // 
            this.dgvManagerInfo.AllowUserToAddRows = false;
            this.dgvManagerInfo.AllowUserToDeleteRows = false;
            this.dgvManagerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManagerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manager_Id,
            this.Manager_Name,
            this.Manager_Phone_No_1,
            this.Manager_Phone_No_2,
            this.Manager_Email,
            this.Manager_Gender,
            this.Manager_Dob,
            this.Manager_Joining_Date,
            this.Manager_NID_No,
            this.Manager_Address,
            this.Manager_Salary,
            this.Manager_Password});
            this.dgvManagerInfo.Location = new System.Drawing.Point(-1, 69);
            this.dgvManagerInfo.Name = "dgvManagerInfo";
            this.dgvManagerInfo.ReadOnly = true;
            this.dgvManagerInfo.RowHeadersWidth = 51;
            this.dgvManagerInfo.RowTemplate.Height = 24;
            this.dgvManagerInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManagerInfo.Size = new System.Drawing.Size(873, 590);
            this.dgvManagerInfo.TabIndex = 1;
            this.dgvManagerInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManagerInfo_CellDoubleClick);
            // 
            // Manager_Id
            // 
            this.Manager_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Id.DataPropertyName = "Manager_Id";
            this.Manager_Id.HeaderText = "ID";
            this.Manager_Id.MinimumWidth = 6;
            this.Manager_Id.Name = "Manager_Id";
            this.Manager_Id.ReadOnly = true;
            // 
            // Manager_Name
            // 
            this.Manager_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Name.DataPropertyName = "Manager_Name";
            this.Manager_Name.HeaderText = "Name";
            this.Manager_Name.MinimumWidth = 6;
            this.Manager_Name.Name = "Manager_Name";
            this.Manager_Name.ReadOnly = true;
            // 
            // Manager_Phone_No_1
            // 
            this.Manager_Phone_No_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Phone_No_1.DataPropertyName = "Manager_Phone_No_1";
            this.Manager_Phone_No_1.HeaderText = "Phone No 1";
            this.Manager_Phone_No_1.MinimumWidth = 6;
            this.Manager_Phone_No_1.Name = "Manager_Phone_No_1";
            this.Manager_Phone_No_1.ReadOnly = true;
            // 
            // Manager_Phone_No_2
            // 
            this.Manager_Phone_No_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Phone_No_2.DataPropertyName = "Manager_Phone_No_2";
            this.Manager_Phone_No_2.HeaderText = "Phone No 2";
            this.Manager_Phone_No_2.MinimumWidth = 6;
            this.Manager_Phone_No_2.Name = "Manager_Phone_No_2";
            this.Manager_Phone_No_2.ReadOnly = true;
            // 
            // Manager_Email
            // 
            this.Manager_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Email.DataPropertyName = "Manager_Email";
            this.Manager_Email.HeaderText = "Email";
            this.Manager_Email.MinimumWidth = 6;
            this.Manager_Email.Name = "Manager_Email";
            this.Manager_Email.ReadOnly = true;
            // 
            // Manager_Gender
            // 
            this.Manager_Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Gender.DataPropertyName = "Manager_Gender";
            this.Manager_Gender.HeaderText = "Gender";
            this.Manager_Gender.MinimumWidth = 6;
            this.Manager_Gender.Name = "Manager_Gender";
            this.Manager_Gender.ReadOnly = true;
            // 
            // Manager_Dob
            // 
            this.Manager_Dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Dob.DataPropertyName = "Manager_Dob";
            this.Manager_Dob.HeaderText = "Date of Birth";
            this.Manager_Dob.MinimumWidth = 6;
            this.Manager_Dob.Name = "Manager_Dob";
            this.Manager_Dob.ReadOnly = true;
            // 
            // Manager_Joining_Date
            // 
            this.Manager_Joining_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Joining_Date.DataPropertyName = "Manager_Joining_Date";
            this.Manager_Joining_Date.HeaderText = "Joining Date";
            this.Manager_Joining_Date.MinimumWidth = 6;
            this.Manager_Joining_Date.Name = "Manager_Joining_Date";
            this.Manager_Joining_Date.ReadOnly = true;
            // 
            // Manager_NID_No
            // 
            this.Manager_NID_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_NID_No.DataPropertyName = "Manager_NID_No";
            this.Manager_NID_No.HeaderText = "NID No";
            this.Manager_NID_No.MinimumWidth = 6;
            this.Manager_NID_No.Name = "Manager_NID_No";
            this.Manager_NID_No.ReadOnly = true;
            // 
            // Manager_Address
            // 
            this.Manager_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Address.DataPropertyName = "Manager_Address";
            this.Manager_Address.HeaderText = "Address";
            this.Manager_Address.MinimumWidth = 6;
            this.Manager_Address.Name = "Manager_Address";
            this.Manager_Address.ReadOnly = true;
            // 
            // Manager_Salary
            // 
            this.Manager_Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Salary.DataPropertyName = "Manager_Salary";
            this.Manager_Salary.HeaderText = "Salary";
            this.Manager_Salary.MinimumWidth = 6;
            this.Manager_Salary.Name = "Manager_Salary";
            this.Manager_Salary.ReadOnly = true;
            // 
            // Manager_Password
            // 
            this.Manager_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Password.DataPropertyName = "Manager_Password";
            this.Manager_Password.HeaderText = "Password";
            this.Manager_Password.MinimumWidth = 6;
            this.Manager_Password.Name = "Manager_Password";
            this.Manager_Password.ReadOnly = true;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(14, 570);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 45);
            this.btnRemove.TabIndex = 60;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(155, 570);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 45);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(178, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "(Format: yyyy-MM-dd)";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Honeydew;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(285, 529);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 31);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoiningDate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoiningDate.Location = new System.Drawing.Point(181, 316);
            this.dtpJoiningDate.MinDate = new System.DateTime(1799, 1, 8, 0, 0, 0, 0);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(214, 27);
            this.dtpJoiningDate.TabIndex = 48;
            this.dtpJoiningDate.Value = new System.DateTime(2025, 1, 15, 1, 15, 0, 0);
            // 
            // dtpDoB
            // 
            this.dtpDoB.CustomFormat = "yyyy-MM-dd";
            this.dtpDoB.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoB.Location = new System.Drawing.Point(181, 258);
            this.dtpDoB.MaxDate = new System.DateTime(2099, 1, 1, 0, 0, 0, 0);
            this.dtpDoB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(214, 27);
            this.dtpDoB.TabIndex = 47;
            this.dtpDoB.Value = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(181, 212);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(214, 28);
            this.cmbGender.TabIndex = 46;
            this.cmbGender.Text = "Select";
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
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txtAutoSearchByName);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtSearchById);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.dgvManagerInfo);
            this.panel5.Location = new System.Drawing.Point(409, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(873, 660);
            this.panel5.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 20);
            this.label14.TabIndex = 63;
            this.label14.Text = "Search by Manager ID";
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(163)))), ((int)(((byte)(139)))));
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.txtPhoneNo2);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.dtpJoiningDate);
            this.panel4.Controls.Add(this.dtpDoB);
            this.panel4.Controls.Add(this.cmbGender);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.txtSalary);
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.txtNID);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.txtPhoneNo1);
            this.panel4.Controls.Add(this.txtFullName);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtId);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 670);
            this.panel4.TabIndex = 29;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(181, 481);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(214, 27);
            this.txtPassword.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(26, 478);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 27);
            this.label17.TabIndex = 63;
            this.label17.Text = "Password";
            // 
            // txtPhoneNo2
            // 
            this.txtPhoneNo2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo2.Location = new System.Drawing.Point(181, 127);
            this.txtPhoneNo2.Name = "txtPhoneNo2";
            this.txtPhoneNo2.Size = new System.Drawing.Size(214, 27);
            this.txtPhoneNo2.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 27);
            this.label16.TabIndex = 61;
            this.label16.Text = "Phone No 2";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(181, 49);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(214, 27);
            this.txtFullName.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 27);
            this.label11.TabIndex = 37;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 27);
            this.label10.TabIndex = 36;
            this.label10.Text = "Date of Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 27);
            this.label9.TabIndex = 35;
            this.label9.Text = "Joining Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "NID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Phone No 1";
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(181, 11);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(214, 27);
            this.txtId.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "Manager ID";
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
            // FormManageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.panel1);
            this.Name = "FormManageManager";
            this.Text = "FormManageManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageManager_FormClosed);
            this.Load += new System.EventHandler(this.FormManageManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerInfo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNo1;
        private System.Windows.Forms.TextBox txtAutoSearchByName;
        private System.Windows.Forms.DataGridView dgvManagerInfo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPhoneNo2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Phone_No_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Phone_No_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Joining_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_NID_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Password;
    }
}