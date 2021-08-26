
namespace TestCode.View.UseControls
{
    partial class Teacher_Result
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfTestCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSubmit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewResult);
            this.panel1.Location = new System.Drawing.Point(129, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 536);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(118, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 1);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Result Table";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.ProblemName,
            this.ProblemResult,
            this.TimeRun,
            this.NumOfTestCase,
            this.TimeSubmit});
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 103);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 33;
            this.dataGridViewResult.Size = new System.Drawing.Size(994, 371);
            this.dataGridViewResult.TabIndex = 13;
            this.dataGridViewResult.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewResult_Paint);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // ProblemName
            // 
            this.ProblemName.DataPropertyName = "ProblemName";
            this.ProblemName.HeaderText = "Problem Name";
            this.ProblemName.MaxInputLength = 40767;
            this.ProblemName.MinimumWidth = 6;
            this.ProblemName.Name = "ProblemName";
            this.ProblemName.ReadOnly = true;
            // 
            // ProblemResult
            // 
            this.ProblemResult.DataPropertyName = "ProblemResult";
            this.ProblemResult.HeaderText = "Problem Result";
            this.ProblemResult.MinimumWidth = 6;
            this.ProblemResult.Name = "ProblemResult";
            this.ProblemResult.ReadOnly = true;
            // 
            // TimeRun
            // 
            this.TimeRun.DataPropertyName = "TimeRun";
            this.TimeRun.HeaderText = "Time Run";
            this.TimeRun.Name = "TimeRun";
            this.TimeRun.ReadOnly = true;
            // 
            // NumOfTestCase
            // 
            this.NumOfTestCase.DataPropertyName = "NumOfTestCase";
            this.NumOfTestCase.HeaderText = "Num Of TestCase";
            this.NumOfTestCase.Name = "NumOfTestCase";
            this.NumOfTestCase.ReadOnly = true;
            // 
            // TimeSubmit
            // 
            this.TimeSubmit.DataPropertyName = "TimeSubmit";
            this.TimeSubmit.HeaderText = "Time Submit";
            this.TimeSubmit.Name = "TimeSubmit";
            this.TimeSubmit.ReadOnly = true;
            // 
            // Teacher_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(756, 445);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(756, 0);
            this.Name = "Teacher_Result";
            this.Size = new System.Drawing.Size(1244, 665);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfTestCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSubmit;
        private System.Windows.Forms.Panel panel2;
    }
}
