
namespace TestCode.View.UseControls
{
    partial class Teacher_Contest
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
            this.label3 = new System.Windows.Forms.Label();
            this.gB = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.NumericUpDown();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.btnEditContest = new System.Windows.Forms.Button();
            this.txtContestID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContestName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProblems = new System.Windows.Forms.DataGridView();
            this.ProblemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResult = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gB);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewProblems);
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Location = new System.Drawing.Point(76, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 690);
            this.panel1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(988, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Result";
            // 
            // gB
            // 
            this.gB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gB.Controls.Add(this.txtTime);
            this.gB.Controls.Add(this.dateTimeStart);
            this.gB.Controls.Add(this.btnEditContest);
            this.gB.Controls.Add(this.txtContestID);
            this.gB.Controls.Add(this.label2);
            this.gB.Controls.Add(this.label6);
            this.gB.Controls.Add(this.label7);
            this.gB.Controls.Add(this.txtContestName);
            this.gB.Controls.Add(this.label8);
            this.gB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB.Location = new System.Drawing.Point(20, 61);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(1062, 236);
            this.gB.TabIndex = 31;
            this.gB.TabStop = false;
            this.gB.Text = "Contest";
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTime.Location = new System.Drawing.Point(259, 139);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(260, 26);
            this.txtTime.TabIndex = 15;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeStart.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(664, 139);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(246, 23);
            this.dateTimeStart.TabIndex = 14;
            this.dateTimeStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimeStart_KeyDown);
            // 
            // btnEditContest
            // 
            this.btnEditContest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditContest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditContest.FlatAppearance.BorderSize = 0;
            this.btnEditContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditContest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditContest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditContest.Location = new System.Drawing.Point(912, 188);
            this.btnEditContest.Name = "btnEditContest";
            this.btnEditContest.Size = new System.Drawing.Size(123, 29);
            this.btnEditContest.TabIndex = 13;
            this.btnEditContest.Text = "Edit Contest";
            this.btnEditContest.UseVisualStyleBackColor = false;
            this.btnEditContest.Click += new System.EventHandler(this.btnEditContest_Click);
            // 
            // txtContestID
            // 
            this.txtContestID.AcceptsReturn = true;
            this.txtContestID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContestID.Location = new System.Drawing.Point(259, 41);
            this.txtContestID.Name = "txtContestID";
            this.txtContestID.ReadOnly = true;
            this.txtContestID.Size = new System.Drawing.Size(651, 26);
            this.txtContestID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contest ID:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(576, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time start:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Time:";
            // 
            // txtContestName
            // 
            this.txtContestName.AcceptsReturn = true;
            this.txtContestName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContestName.Location = new System.Drawing.Point(259, 89);
            this.txtContestName.Name = "txtContestName";
            this.txtContestName.Size = new System.Drawing.Size(651, 26);
            this.txtContestName.TabIndex = 3;
            this.txtContestName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContestName_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Contest Name:";
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::TestCode.Properties.Resources.left_arrow__1_;
            this.btnHome.Location = new System.Drawing.Point(3, 16);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(46, 33);
            this.btnHome.TabIndex = 21;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "List of Problem";
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
            this.ProblemID,
            this.ProblemName,
            this.Content});
            this.dataGridViewProblems.Location = new System.Drawing.Point(20, 351);
            this.dataGridViewProblems.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProblems.Name = "dataGridViewProblems";
            this.dataGridViewProblems.ReadOnly = true;
            this.dataGridViewProblems.RowHeadersVisible = false;
            this.dataGridViewProblems.RowHeadersWidth = 51;
            this.dataGridViewProblems.RowTemplate.Height = 33;
            this.dataGridViewProblems.Size = new System.Drawing.Size(1059, 216);
            this.dataGridViewProblems.TabIndex = 19;
            // 
            // ProblemID
            // 
            this.ProblemID.HeaderText = "Problem ID";
            this.ProblemID.Name = "ProblemID";
            this.ProblemID.ReadOnly = true;
            // 
            // ProblemName
            // 
            this.ProblemName.DataPropertyName = "ProblemName";
            this.ProblemName.HeaderText = "ProblemName";
            this.ProblemName.MinimumWidth = 6;
            this.ProblemName.Name = "ProblemName";
            this.ProblemName.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.HeaderText = "Content";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // btnResult
            // 
            this.btnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Image = global::TestCode.Properties.Resources.right_arrow__2_;
            this.btnResult.Location = new System.Drawing.Point(1050, 16);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(32, 33);
            this.btnResult.TabIndex = 32;
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Teacher_Contest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1200, 800);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1200, 0);
            this.Name = "Teacher_Contest";
            this.Size = new System.Drawing.Size(1243, 761);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gB.ResumeLayout(false);
            this.gB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContestName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProblems;
        private System.Windows.Forms.TextBox txtContestID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.Button btnEditContest;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtTime;
    }
}
