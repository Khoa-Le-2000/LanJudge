
namespace TestCode.View.UseControls
{
    partial class Student_Contest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.dataGridViewProblems = new System.Windows.Forms.DataGridView();
            this.ProblemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblems)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-4, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contest";
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.Navy;
            this.txtContent.Location = new System.Drawing.Point(3, 98);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(977, 46);
            this.txtContent.TabIndex = 5;
            // 
            // dataGridViewProblems
            // 
            this.dataGridViewProblems.AllowUserToAddRows = false;
            this.dataGridViewProblems.AllowUserToDeleteRows = false;
            this.dataGridViewProblems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProblems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProblems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProblems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProblemId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewProblems.Location = new System.Drawing.Point(0, 161);
            this.dataGridViewProblems.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProblems.Name = "dataGridViewProblems";
            this.dataGridViewProblems.ReadOnly = true;
            this.dataGridViewProblems.RowHeadersVisible = false;
            this.dataGridViewProblems.RowHeadersWidth = 51;
            this.dataGridViewProblems.RowTemplate.Height = 33;
            this.dataGridViewProblems.Size = new System.Drawing.Size(981, 377);
            this.dataGridViewProblems.TabIndex = 9;
            this.dataGridViewProblems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProblems_CellDoubleClick);
            // 
            // ProblemId
            // 
            this.ProblemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProblemId.FillWeight = 171.9208F;
            this.ProblemId.HeaderText = "ProblemId";
            this.ProblemId.Name = "ProblemId";
            this.ProblemId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProblemName";
            this.dataGridViewTextBoxColumn1.FillWeight = 63.6741F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ProblemName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn2.FillWeight = 103.0891F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Content";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dataGridViewProblems);
            this.panel2.Controls.Add(this.txtContent);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(112, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 603);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(-12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 1);
            this.panel1.TabIndex = 10;
            // 
            // Student_Contest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(670, 473);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(670, 200);
            this.Name = "Student_Contest";
            this.Size = new System.Drawing.Size(1181, 684);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.DataGridView dataGridViewProblems;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
