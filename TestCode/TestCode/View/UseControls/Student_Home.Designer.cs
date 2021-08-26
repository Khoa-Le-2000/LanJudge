
namespace TestCode.View.UseControls
{
    partial class Student_Home
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelContests = new System.Windows.Forms.Label();
            this.dataGridViewContest = new System.Windows.Forms.DataGridView();
            this.ContestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timetest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewContesting = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContesting)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridViewContesting);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelSearch);
            this.panel2.Controls.Add(this.labelContests);
            this.panel2.Controls.Add(this.dataGridViewContest);
            this.panel2.Location = new System.Drawing.Point(109, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 627);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(3, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 1);
            this.panel3.TabIndex = 12;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.panel1);
            this.panelSearch.Controls.Add(this.pictureBox1);
            this.panelSearch.Location = new System.Drawing.Point(822, 65);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(211, 25);
            this.panelSearch.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(34, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 16);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search for contest...";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(34, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 2);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestCode.Properties.Resources.search__1_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelContests
            // 
            this.labelContests.AutoSize = true;
            this.labelContests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContests.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelContests.Location = new System.Drawing.Point(-4, 21);
            this.labelContests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContests.Name = "labelContests";
            this.labelContests.Size = new System.Drawing.Size(98, 25);
            this.labelContests.TabIndex = 4;
            this.labelContests.Text = "Contests";
            // 
            // dataGridViewContest
            // 
            this.dataGridViewContest.AllowUserToAddRows = false;
            this.dataGridViewContest.AllowUserToDeleteRows = false;
            this.dataGridViewContest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContest.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewContest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewContest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContestID,
            this.ContestName,
            this.Timetest,
            this.TimeStart});
            this.dataGridViewContest.Location = new System.Drawing.Point(1, 342);
            this.dataGridViewContest.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewContest.Name = "dataGridViewContest";
            this.dataGridViewContest.ReadOnly = true;
            this.dataGridViewContest.RowHeadersVisible = false;
            this.dataGridViewContest.RowHeadersWidth = 51;
            this.dataGridViewContest.RowTemplate.Height = 33;
            this.dataGridViewContest.Size = new System.Drawing.Size(1030, 270);
            this.dataGridViewContest.TabIndex = 2;
            this.dataGridViewContest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContest_CellDoubleClick);
            // 
            // ContestID
            // 
            this.ContestID.DataPropertyName = "ContestID";
            this.ContestID.Frozen = true;
            this.ContestID.HeaderText = "Contest ID";
            this.ContestID.Name = "ContestID";
            this.ContestID.ReadOnly = true;
            this.ContestID.Width = 150;
            // 
            // ContestName
            // 
            this.ContestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContestName.DataPropertyName = "ContestName";
            this.ContestName.HeaderText = "Contest Name";
            this.ContestName.Name = "ContestName";
            this.ContestName.ReadOnly = true;
            // 
            // Timetest
            // 
            this.Timetest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Timetest.DataPropertyName = "Timetest";
            this.Timetest.HeaderText = "Time ";
            this.Timetest.Name = "Timetest";
            this.Timetest.ReadOnly = true;
            // 
            // TimeStart
            // 
            this.TimeStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeStart.DataPropertyName = "TimeStart";
            this.TimeStart.HeaderText = "Time Start";
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.ReadOnly = true;
            // 
            // dataGridViewContesting
            // 
            this.dataGridViewContesting.AllowUserToAddRows = false;
            this.dataGridViewContesting.AllowUserToDeleteRows = false;
            this.dataGridViewContesting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContesting.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewContesting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewContesting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContesting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewContesting.Location = new System.Drawing.Point(1, 145);
            this.dataGridViewContesting.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewContesting.Name = "dataGridViewContesting";
            this.dataGridViewContesting.ReadOnly = true;
            this.dataGridViewContesting.RowHeadersVisible = false;
            this.dataGridViewContesting.RowHeadersWidth = 51;
            this.dataGridViewContesting.RowTemplate.Height = 33;
            this.dataGridViewContesting.Size = new System.Drawing.Size(1030, 136);
            this.dataGridViewContesting.TabIndex = 13;
            this.dataGridViewContesting.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContesting_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ContestID";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Contest ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ContestName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Contest Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Timetest";
            this.dataGridViewTextBoxColumn3.HeaderText = "Time ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TimeStart";
            this.dataGridViewTextBoxColumn4.HeaderText = "Time Start";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-4, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Current Contests";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-1, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "All Contests";
            // 
            // Student_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(706, 533);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(672, 250);
            this.Name = "Student_Home";
            this.Size = new System.Drawing.Size(1234, 727);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContesting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewContest;
        private System.Windows.Forms.Label labelContests;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timetest;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart;
        private System.Windows.Forms.DataGridView dataGridViewContesting;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
