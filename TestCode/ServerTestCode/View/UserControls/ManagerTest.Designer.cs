
namespace ServerTestCode.View.UserControls
{
    partial class ManagerTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerTest));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.TestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblManagerTest = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeTest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.lblVisible = new System.Windows.Forms.Label();
            this.txtTimeStart = new System.Windows.Forms.TextBox();
            this.panelEditTest = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            this.panelEditTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(56, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(53, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Search:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.AllowUserToAddRows = false;
            this.dataGridViewTest.AllowUserToDeleteRows = false;
            this.dataGridViewTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestID,
            this.TestName,
            this.TimeTest,
            this.TimeStart});
            this.dataGridViewTest.Location = new System.Drawing.Point(56, 127);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.ReadOnly = true;
            this.dataGridViewTest.RowHeadersVisible = false;
            this.dataGridViewTest.Size = new System.Drawing.Size(751, 198);
            this.dataGridViewTest.TabIndex = 36;
            this.dataGridViewTest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTest_CellDoubleClick);
            // 
            // TestID
            // 
            this.TestID.DataPropertyName = "TestID";
            this.TestID.HeaderText = "Test ID";
            this.TestID.Name = "TestID";
            this.TestID.ReadOnly = true;
            this.TestID.Width = 200;
            // 
            // TestName
            // 
            this.TestName.DataPropertyName = "TestName";
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            this.TestName.Width = 250;
            // 
            // TimeTest
            // 
            this.TimeTest.DataPropertyName = "TimeTest";
            this.TimeTest.HeaderText = "Time Test";
            this.TimeTest.Name = "TimeTest";
            this.TimeTest.ReadOnly = true;
            this.TimeTest.Width = 150;
            // 
            // TimeStart
            // 
            this.TimeStart.DataPropertyName = "TimeStart";
            this.TimeStart.HeaderText = "Time Start";
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.ReadOnly = true;
            this.TimeStart.Width = 150;
            // 
            // lblManagerTest
            // 
            this.lblManagerTest.AutoSize = true;
            this.lblManagerTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblManagerTest.Location = new System.Drawing.Point(53, 39);
            this.lblManagerTest.Name = "lblManagerTest";
            this.lblManagerTest.Size = new System.Drawing.Size(138, 24);
            this.lblManagerTest.TabIndex = 35;
            this.lblManagerTest.Text = "Manager Test";
            this.lblManagerTest.Click += new System.EventHandler(this.lblManagerTest_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(781, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(26, 26);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 18);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Edit Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(152, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Test ID:";
            // 
            // txtTestID
            // 
            this.txtTestID.Location = new System.Drawing.Point(221, 38);
            this.txtTestID.Name = "txtTestID";
            this.txtTestID.ReadOnly = true;
            this.txtTestID.Size = new System.Drawing.Size(313, 20);
            this.txtTestID.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(142, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Time Test:";
            // 
            // txtTimeTest
            // 
            this.txtTimeTest.Location = new System.Drawing.Point(221, 114);
            this.txtTimeTest.Name = "txtTimeTest";
            this.txtTimeTest.Size = new System.Drawing.Size(313, 20);
            this.txtTimeTest.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(142, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Time Start:";
            // 
            // btnEditTest
            // 
            this.btnEditTest.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEditTest.FlatAppearance.BorderSize = 0;
            this.btnEditTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditTest.Location = new System.Drawing.Point(221, 192);
            this.btnEditTest.Name = "btnEditTest";
            this.btnEditTest.Size = new System.Drawing.Size(313, 25);
            this.btnEditTest.TabIndex = 31;
            this.btnEditTest.Text = "Edit Test";
            this.btnEditTest.UseVisualStyleBackColor = false;
            this.btnEditTest.Click += new System.EventHandler(this.btnEditTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(142, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Test Name:";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(221, 77);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(313, 20);
            this.txtTestName.TabIndex = 33;
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
            // txtTimeStart
            // 
            this.txtTimeStart.Location = new System.Drawing.Point(221, 151);
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(313, 20);
            this.txtTimeStart.TabIndex = 35;
            // 
            // panelEditTest
            // 
            this.panelEditTest.Controls.Add(this.txtTimeStart);
            this.panelEditTest.Controls.Add(this.lblVisible);
            this.panelEditTest.Controls.Add(this.txtTestName);
            this.panelEditTest.Controls.Add(this.label1);
            this.panelEditTest.Controls.Add(this.btnEditTest);
            this.panelEditTest.Controls.Add(this.label6);
            this.panelEditTest.Controls.Add(this.txtTimeTest);
            this.panelEditTest.Controls.Add(this.label5);
            this.panelEditTest.Controls.Add(this.txtTestID);
            this.panelEditTest.Controls.Add(this.label3);
            this.panelEditTest.Controls.Add(this.lblTitle);
            this.panelEditTest.Location = new System.Drawing.Point(56, 342);
            this.panelEditTest.Name = "panelEditTest";
            this.panelEditTest.Size = new System.Drawing.Size(751, 244);
            this.panelEditTest.TabIndex = 43;
            this.panelEditTest.Visible = false;
            // 
            // ManagerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEditTest);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewTest);
            this.Controls.Add(this.lblManagerTest);
            this.Name = "ManagerTest";
            this.Size = new System.Drawing.Size(861, 599);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            this.panelEditTest.ResumeLayout(false);
            this.panelEditTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.Label lblManagerTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimeTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label lblVisible;
        private System.Windows.Forms.TextBox txtTimeStart;
        private System.Windows.Forms.Panel panelEditTest;
    }
}
