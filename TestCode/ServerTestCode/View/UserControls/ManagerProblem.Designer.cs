
namespace ServerTestCode.View.UserControls
{
    partial class ManagerProblem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerProblem));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewProblem = new System.Windows.Forms.DataGridView();
            this.ProblemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblManagerProblem = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelEditproblem = new System.Windows.Forms.Panel();
            this.txtTestID = new System.Windows.Forms.TextBox();
            this.lblVisible = new System.Windows.Forms.Label();
            this.txtProblemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditProblem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProblemID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblem)).BeginInit();
            this.panelEditproblem.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(56, 96);
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
            this.label7.Location = new System.Drawing.Point(53, 78);
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
            // dataGridViewProblem
            // 
            this.dataGridViewProblem.AllowUserToAddRows = false;
            this.dataGridViewProblem.AllowUserToDeleteRows = false;
            this.dataGridViewProblem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProblem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProblem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProblemID,
            this.ProblemName,
            this.Content,
            this.TestID});
            this.dataGridViewProblem.Location = new System.Drawing.Point(56, 122);
            this.dataGridViewProblem.Name = "dataGridViewProblem";
            this.dataGridViewProblem.ReadOnly = true;
            this.dataGridViewProblem.RowHeadersVisible = false;
            this.dataGridViewProblem.Size = new System.Drawing.Size(751, 198);
            this.dataGridViewProblem.TabIndex = 36;
            this.dataGridViewProblem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProblem_CellContentDoubleClick);
            // 
            // ProblemID
            // 
            this.ProblemID.DataPropertyName = "ProblemID";
            this.ProblemID.HeaderText = "Problem ID";
            this.ProblemID.Name = "ProblemID";
            this.ProblemID.ReadOnly = true;
            this.ProblemID.Width = 150;
            // 
            // ProblemName
            // 
            this.ProblemName.DataPropertyName = "ProblemName";
            this.ProblemName.HeaderText = "Problem Name";
            this.ProblemName.Name = "ProblemName";
            this.ProblemName.ReadOnly = true;
            this.ProblemName.Width = 250;
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Width = 200;
            // 
            // TestID
            // 
            this.TestID.DataPropertyName = "TestID";
            this.TestID.HeaderText = "Test ID";
            this.TestID.Name = "TestID";
            this.TestID.ReadOnly = true;
            this.TestID.Width = 150;
            // 
            // lblManagerProblem
            // 
            this.lblManagerProblem.AutoSize = true;
            this.lblManagerProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerProblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblManagerProblem.Location = new System.Drawing.Point(53, 34);
            this.lblManagerProblem.Name = "lblManagerProblem";
            this.lblManagerProblem.Size = new System.Drawing.Size(176, 24);
            this.lblManagerProblem.TabIndex = 35;
            this.lblManagerProblem.Text = "Manager Problem";
            this.lblManagerProblem.Click += new System.EventHandler(this.lblManagerProblem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(781, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(26, 26);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelEditproblem
            // 
            this.panelEditproblem.Controls.Add(this.txtTestID);
            this.panelEditproblem.Controls.Add(this.lblVisible);
            this.panelEditproblem.Controls.Add(this.txtProblemName);
            this.panelEditproblem.Controls.Add(this.label1);
            this.panelEditproblem.Controls.Add(this.btnEditProblem);
            this.panelEditproblem.Controls.Add(this.label6);
            this.panelEditproblem.Controls.Add(this.txtContent);
            this.panelEditproblem.Controls.Add(this.label5);
            this.panelEditproblem.Controls.Add(this.txtProblemID);
            this.panelEditproblem.Controls.Add(this.label3);
            this.panelEditproblem.Controls.Add(this.lblTitle);
            this.panelEditproblem.Location = new System.Drawing.Point(56, 338);
            this.panelEditproblem.Name = "panelEditproblem";
            this.panelEditproblem.Size = new System.Drawing.Size(751, 244);
            this.panelEditproblem.TabIndex = 42;
            this.panelEditproblem.Visible = false;
            // 
            // txtTestID
            // 
            this.txtTestID.Location = new System.Drawing.Point(220, 151);
            this.txtTestID.Name = "txtTestID";
            this.txtTestID.ReadOnly = true;
            this.txtTestID.Size = new System.Drawing.Size(313, 20);
            this.txtTestID.TabIndex = 35;
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
            // txtProblemName
            // 
            this.txtProblemName.Location = new System.Drawing.Point(220, 77);
            this.txtProblemName.Name = "txtProblemName";
            this.txtProblemName.Size = new System.Drawing.Size(313, 20);
            this.txtProblemName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(120, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Problem Name:";
            // 
            // btnEditProblem
            // 
            this.btnEditProblem.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEditProblem.FlatAppearance.BorderSize = 0;
            this.btnEditProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProblem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditProblem.Location = new System.Drawing.Point(220, 192);
            this.btnEditProblem.Name = "btnEditProblem";
            this.btnEditProblem.Size = new System.Drawing.Size(313, 25);
            this.btnEditProblem.TabIndex = 31;
            this.btnEditProblem.Text = "Edit Problem";
            this.btnEditProblem.UseVisualStyleBackColor = false;
            this.btnEditProblem.Click += new System.EventHandler(this.btnEditProblem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(141, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Test ID:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(220, 114);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(313, 20);
            this.txtContent.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(141, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Content:";
            // 
            // txtProblemID
            // 
            this.txtProblemID.Location = new System.Drawing.Point(220, 38);
            this.txtProblemID.Name = "txtProblemID";
            this.txtProblemID.ReadOnly = true;
            this.txtProblemID.Size = new System.Drawing.Size(313, 20);
            this.txtProblemID.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(131, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Problem ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 18);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Edit Problem";
            // 
            // ManagerProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEditproblem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewProblem);
            this.Controls.Add(this.lblManagerProblem);
            this.Name = "ManagerProblem";
            this.Size = new System.Drawing.Size(861, 599);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblem)).EndInit();
            this.panelEditproblem.ResumeLayout(false);
            this.panelEditproblem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewProblem;
        private System.Windows.Forms.Label lblManagerProblem;
        private System.Windows.Forms.Panel panelEditproblem;
        private System.Windows.Forms.Label lblVisible;
        private System.Windows.Forms.TextBox txtProblemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditProblem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProblemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestID;
        private System.Windows.Forms.TextBox txtTestID;
    }
}
