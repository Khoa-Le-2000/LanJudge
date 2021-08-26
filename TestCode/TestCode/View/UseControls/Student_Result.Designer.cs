
namespace TestCode.View.UseControls
{
    partial class Student_Result
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.ProblemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfTestCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSubmit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridViewResult);
            this.panel2.Location = new System.Drawing.Point(102, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 477);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(138, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 1);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Result Contest";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProblemID,
            this.ProblemName,
            this.ProblemResult,
            this.TimeRun,
            this.NumOfTestCase,
            this.TimeSubmit});
            this.dataGridViewResult.Location = new System.Drawing.Point(3, 106);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 33;
            this.dataGridViewResult.Size = new System.Drawing.Size(986, 347);
            this.dataGridViewResult.TabIndex = 13;
            this.dataGridViewResult.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewResult_Paint);
            // 
            // ProblemID
            // 
            this.ProblemID.DataPropertyName = "ProblemID";
            this.ProblemID.HeaderText = "Problem ID";
            this.ProblemID.Name = "ProblemID";
            this.ProblemID.ReadOnly = true;
            // 
            // ProblemName
            // 
            this.ProblemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProblemName.DataPropertyName = "ProblemName";
            this.ProblemName.HeaderText = "Problem Name";
            this.ProblemName.MaxInputLength = 40767;
            this.ProblemName.MinimumWidth = 6;
            this.ProblemName.Name = "ProblemName";
            this.ProblemName.ReadOnly = true;
            // 
            // ProblemResult
            // 
            this.ProblemResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProblemResult.DataPropertyName = "ProblemResult";
            this.ProblemResult.HeaderText = "Problem Result";
            this.ProblemResult.MinimumWidth = 6;
            this.ProblemResult.Name = "ProblemResult";
            this.ProblemResult.ReadOnly = true;
            // 
            // TimeRun
            // 
            this.TimeRun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeRun.DataPropertyName = "TimeRun";
            this.TimeRun.HeaderText = "Time Run";
            this.TimeRun.Name = "TimeRun";
            this.TimeRun.ReadOnly = true;
            // 
            // NumOfTestCase
            // 
            this.NumOfTestCase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumOfTestCase.DataPropertyName = "NumOfTestCase";
            this.NumOfTestCase.HeaderText = "Num Of TestCase";
            this.NumOfTestCase.Name = "NumOfTestCase";
            this.NumOfTestCase.ReadOnly = true;
            // 
            // TimeSubmit
            // 
            this.TimeSubmit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeSubmit.DataPropertyName = "TimeSubmit";
            this.TimeSubmit.HeaderText = "Time Submit";
            this.TimeSubmit.Name = "TimeSubmit";
            this.TimeSubmit.ReadOnly = true;
            // 
            // Student_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(642, 467);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(642, 200);
            this.Name = "Student_Result";
            this.Size = new System.Drawing.Size(1192, 577);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfTestCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSubmit;
    }
}
