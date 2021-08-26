
using System.Windows.Forms;

namespace TestCode.View.UseControls
{
    partial class Teacher_Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblContest = new System.Windows.Forms.Label();
            this.dataGridViewContest = new System.Windows.Forms.DataGridView();
            this.ContestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timetest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.panelSearch);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Controls.Add(this.lblContest);
            this.panel2.Controls.Add(this.dataGridViewContest);
            this.panel2.Location = new System.Drawing.Point(66, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 461);
            this.panel2.TabIndex = 17;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.panel1);
            this.panelSearch.Controls.Add(this.pictureBox1);
            this.panelSearch.Location = new System.Drawing.Point(578, 48);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(252, 25);
            this.panelSearch.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(34, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 16);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search for contest...";
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(34, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 1);
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
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNew.Location = new System.Drawing.Point(102, 49);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 7;
            this.btnAddNew.Text = "+ Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblContest
            // 
            this.lblContest.AutoSize = true;
            this.lblContest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContest.Location = new System.Drawing.Point(3, 48);
            this.lblContest.Name = "lblContest";
            this.lblContest.Size = new System.Drawing.Size(87, 25);
            this.lblContest.TabIndex = 6;
            this.lblContest.Text = "Contest";
            this.lblContest.Click += new System.EventHandler(this.lblContest_Click);
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
            this.TimeStart,
            this.Result,
            this.Edit,
            this.Delete});
            this.dataGridViewContest.Location = new System.Drawing.Point(0, 92);
            this.dataGridViewContest.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewContest.Name = "dataGridViewContest";
            this.dataGridViewContest.ReadOnly = true;
            this.dataGridViewContest.RowHeadersVisible = false;
            this.dataGridViewContest.RowHeadersWidth = 51;
            this.dataGridViewContest.RowTemplate.Height = 33;
            this.dataGridViewContest.Size = new System.Drawing.Size(830, 252);
            this.dataGridViewContest.TabIndex = 2;
            this.dataGridViewContest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContest_CellDoubleClick);
            // 
            // ContestID
            // 
            this.ContestID.DataPropertyName = "ContestID";
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
            // Result
            // 
            this.Result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Result.HeaderText = "Result";
            this.Result.Image = global::TestCode.Properties.Resources.notepad;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 43;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::TestCode.Properties.Resources.edit__3_;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 31;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::TestCode.Properties.Resources.cancel;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 44;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::TestCode.Properties.Resources.edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::TestCode.Properties.Resources.cancel;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Teacher_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(900, 550);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(851, 0);
            this.Name = "Teacher_Home";
            this.Size = new System.Drawing.Size(982, 604);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewContest;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private TextBox txtSearch;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private Button btnAddNew;
        private Label lblContest;
        private Panel panelSearch;
        private Panel panel1;
        private DataGridViewTextBoxColumn ContestID;
        private DataGridViewTextBoxColumn ContestName;
        private DataGridViewTextBoxColumn Timetest;
        private DataGridViewTextBoxColumn TimeStart;
        private DataGridViewImageColumn Result;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
