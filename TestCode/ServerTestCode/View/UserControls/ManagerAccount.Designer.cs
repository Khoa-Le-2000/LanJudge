
namespace ServerTestCode.View.UserControls
{
    partial class ManagerAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerAccount));
            this.lblManagerAccount = new System.Windows.Forms.Label();
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCreateNewAccount = new System.Windows.Forms.Panel();
            this.cmbPermission = new System.Windows.Forms.ComboBox();
            this.lblVisible = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            this.panelCreateNewAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManagerAccount
            // 
            this.lblManagerAccount.AutoSize = true;
            this.lblManagerAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblManagerAccount.Location = new System.Drawing.Point(49, 36);
            this.lblManagerAccount.Name = "lblManagerAccount";
            this.lblManagerAccount.Size = new System.Drawing.Size(175, 24);
            this.lblManagerAccount.TabIndex = 16;
            this.lblManagerAccount.Text = "Manager Account";
            this.lblManagerAccount.Click += new System.EventHandler(this.lblManagerAccount_Click);
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.AllowUserToAddRows = false;
            this.dataGridViewAccount.AllowUserToDeleteRows = false;
            this.dataGridViewAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountID,
            this.UserName,
            this.Password,
            this.FullName,
            this.Permission});
            this.dataGridViewAccount.Location = new System.Drawing.Point(52, 124);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.ReadOnly = true;
            this.dataGridViewAccount.RowHeadersVisible = false;
            this.dataGridViewAccount.Size = new System.Drawing.Size(751, 198);
            this.dataGridViewAccount.TabIndex = 17;
            this.dataGridViewAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccount_CellDoubleClick);
            // 
            // AccountID
            // 
            this.AccountID.DataPropertyName = "AccountID";
            this.AccountID.HeaderText = "AccountID";
            this.AccountID.Name = "AccountID";
            this.AccountID.ReadOnly = true;
            this.AccountID.Width = 150;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 200;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            this.Password.Width = 150;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 250;
            // 
            // Permission
            // 
            this.Permission.DataPropertyName = "Permission";
            this.Permission.HeaderText = "Permission";
            this.Permission.Name = "Permission";
            this.Permission.ReadOnly = true;
            this.Permission.Width = 200;
            // 
            // panelCreateNewAccount
            // 
            this.panelCreateNewAccount.Controls.Add(this.cmbPermission);
            this.panelCreateNewAccount.Controls.Add(this.lblVisible);
            this.panelCreateNewAccount.Controls.Add(this.txtPassword);
            this.panelCreateNewAccount.Controls.Add(this.label1);
            this.panelCreateNewAccount.Controls.Add(this.btnCreateAccount);
            this.panelCreateNewAccount.Controls.Add(this.label6);
            this.panelCreateNewAccount.Controls.Add(this.txtFullName);
            this.panelCreateNewAccount.Controls.Add(this.label5);
            this.panelCreateNewAccount.Controls.Add(this.txtUserName);
            this.panelCreateNewAccount.Controls.Add(this.label3);
            this.panelCreateNewAccount.Controls.Add(this.lblTitle);
            this.panelCreateNewAccount.Location = new System.Drawing.Point(53, 340);
            this.panelCreateNewAccount.Name = "panelCreateNewAccount";
            this.panelCreateNewAccount.Size = new System.Drawing.Size(751, 244);
            this.panelCreateNewAccount.TabIndex = 20;
            this.panelCreateNewAccount.Visible = false;
            // 
            // cmbPermission
            // 
            this.cmbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermission.Items.AddRange(new object[] {
            "Admin",
            "Teacher",
            "Student"});
            this.cmbPermission.Location = new System.Drawing.Point(227, 154);
            this.cmbPermission.Name = "cmbPermission";
            this.cmbPermission.Size = new System.Drawing.Size(308, 21);
            this.cmbPermission.TabIndex = 35;
            // 
            // lblVisible
            // 
            this.lblVisible.AutoSize = true;
            this.lblVisible.Location = new System.Drawing.Point(31, 36);
            this.lblVisible.Name = "lblVisible";
            this.lblVisible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVisible.Size = new System.Drawing.Size(0, 13);
            this.lblVisible.TabIndex = 34;
            this.lblVisible.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(223, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(313, 20);
            this.txtPassword.TabIndex = 33;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(144, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Password";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreateAccount.Location = new System.Drawing.Point(223, 192);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(313, 25);
            this.btnCreateAccount.TabIndex = 31;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(144, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Permission:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(223, 114);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(313, 20);
            this.txtFullName.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(144, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Full Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(223, 38);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(313, 20);
            this.txtUserName.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(144, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "User Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 18);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Create a new Account";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(49, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(52, 98);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnNewAccount.FlatAppearance.BorderSize = 0;
            this.btnNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAccount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewAccount.Location = new System.Drawing.Point(644, 92);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(127, 25);
            this.btnNewAccount.TabIndex = 33;
            this.btnNewAccount.Text = "New Account";
            this.btnNewAccount.UseVisualStyleBackColor = false;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(777, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(26, 26);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ManagerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelCreateNewAccount);
            this.Controls.Add(this.dataGridViewAccount);
            this.Controls.Add(this.lblManagerAccount);
            this.Name = "ManagerAccount";
            this.Size = new System.Drawing.Size(861, 599);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            this.panelCreateNewAccount.ResumeLayout(false);
            this.panelCreateNewAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblManagerAccount;
        private System.Windows.Forms.DataGridView dataGridViewAccount;
        private System.Windows.Forms.Panel panelCreateNewAccount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblVisible;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permission;
        private System.Windows.Forms.ComboBox cmbPermission;
    }
}
