
namespace TestCode.View.UseControls
{
    partial class test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCreateContest = new System.Windows.Forms.Button();
            this.dataGridViewProblems = new System.Windows.Forms.DataGridView();
            this.ProblemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ouput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBNewProblem = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProblemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnFileDe = new System.Windows.Forms.Button();
            this.btnCreateProblem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblems)).BeginInit();
            this.gBNewProblem.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btnCreateContest);
            this.panel1.Controls.Add(this.dataGridViewProblems);
            this.panel1.Controls.Add(this.gBNewProblem);
            this.panel1.Controls.Add(this.btnCreateProblem);
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 700);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(949, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 10);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::TestCode.Properties.Resources.cancel;
            this.btnDelete.Location = new System.Drawing.Point(982, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(18, 18);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1, 71);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(708, 10);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // btnCreateContest
            // 
            this.btnCreateContest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateContest.BackColor = System.Drawing.Color.LightGray;
            this.btnCreateContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateContest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateContest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateContest.Location = new System.Drawing.Point(827, 49);
            this.btnCreateContest.Name = "btnCreateContest";
            this.btnCreateContest.Size = new System.Drawing.Size(117, 32);
            this.btnCreateContest.TabIndex = 20;
            this.btnCreateContest.Text = "Create Contest";
            this.btnCreateContest.UseVisualStyleBackColor = false;
            // 
            // dataGridViewProblems
            // 
            this.dataGridViewProblems.AllowUserToAddRows = false;
            this.dataGridViewProblems.AllowUserToDeleteRows = false;
            this.dataGridViewProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProblems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProblemID,
            this.ProblemName,
            this.Content,
            this.Input,
            this.Ouput});
            this.dataGridViewProblems.Location = new System.Drawing.Point(0, 131);
            this.dataGridViewProblems.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProblems.Name = "dataGridViewProblems";
            this.dataGridViewProblems.ReadOnly = true;
            this.dataGridViewProblems.RowHeadersVisible = false;
            this.dataGridViewProblems.RowHeadersWidth = 51;
            this.dataGridViewProblems.RowTemplate.Height = 24;
            this.dataGridViewProblems.Size = new System.Drawing.Size(1000, 215);
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
            this.ProblemName.Width = 300;
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.HeaderText = "Content";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Width = 250;
            // 
            // Input
            // 
            this.Input.DataPropertyName = "Input";
            this.Input.HeaderText = "Input";
            this.Input.MinimumWidth = 6;
            this.Input.Name = "Input";
            this.Input.ReadOnly = true;
            this.Input.Width = 180;
            // 
            // Ouput
            // 
            this.Ouput.HeaderText = "Output";
            this.Ouput.Name = "Ouput";
            this.Ouput.ReadOnly = true;
            this.Ouput.Width = 170;
            // 
            // gBNewProblem
            // 
            this.gBNewProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBNewProblem.Controls.Add(this.btnCreate);
            this.gBNewProblem.Controls.Add(this.panel5);
            this.gBNewProblem.Controls.Add(this.panel6);
            this.gBNewProblem.Controls.Add(this.label5);
            this.gBNewProblem.Controls.Add(this.label4);
            this.gBNewProblem.Controls.Add(this.txtProblemName);
            this.gBNewProblem.Controls.Add(this.label3);
            this.gBNewProblem.Controls.Add(this.label2);
            this.gBNewProblem.Controls.Add(this.panel2);
            this.gBNewProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBNewProblem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gBNewProblem.Location = new System.Drawing.Point(23, 360);
            this.gBNewProblem.Name = "gBNewProblem";
            this.gBNewProblem.Size = new System.Drawing.Size(956, 318);
            this.gBNewProblem.TabIndex = 18;
            this.gBNewProblem.TabStop = false;
            this.gBNewProblem.Text = "NEW PROBLEM";
            this.gBNewProblem.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(225, 271);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(474, 29);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "CREATE PROBLEM";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtInput);
            this.panel5.Controls.Add(this.btnInput);
            this.panel5.Location = new System.Drawing.Point(225, 154);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(474, 28);
            this.panel5.TabIndex = 16;
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(436, 26);
            this.txtInput.TabIndex = 14;
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.White;
            this.btnInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInput.FlatAppearance.BorderSize = 0;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnInput.Image = ((System.Drawing.Image)(resources.GetObject("btnInput.Image")));
            this.btnInput.Location = new System.Drawing.Point(439, 0);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(33, 26);
            this.btnInput.TabIndex = 11;
            this.btnInput.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtOutput);
            this.panel6.Controls.Add(this.btnOutput);
            this.panel6.Location = new System.Drawing.Point(224, 214);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(474, 28);
            this.panel6.TabIndex = 16;
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(434, 26);
            this.txtOutput.TabIndex = 14;
            // 
            // btnOutput
            // 
            this.btnOutput.BackColor = System.Drawing.Color.White;
            this.btnOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOutput.FlatAppearance.BorderSize = 0;
            this.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutput.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.Location = new System.Drawing.Point(439, 0);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(2);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(33, 26);
            this.btnOutput.TabIndex = 11;
            this.btnOutput.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(151, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Output:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(160, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Input:";
            // 
            // txtProblemName
            // 
            this.txtProblemName.Location = new System.Drawing.Point(225, 40);
            this.txtProblemName.Name = "txtProblemName";
            this.txtProblemName.Size = new System.Drawing.Size(474, 27);
            this.txtProblemName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(151, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Content:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(130, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Problem Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtContent);
            this.panel2.Controls.Add(this.btnFileDe);
            this.panel2.Location = new System.Drawing.Point(226, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 28);
            this.panel2.TabIndex = 15;
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(420, 26);
            this.txtContent.TabIndex = 14;
            // 
            // btnFileDe
            // 
            this.btnFileDe.BackColor = System.Drawing.Color.White;
            this.btnFileDe.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFileDe.FlatAppearance.BorderSize = 0;
            this.btnFileDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDe.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFileDe.Image = ((System.Drawing.Image)(resources.GetObject("btnFileDe.Image")));
            this.btnFileDe.Location = new System.Drawing.Point(439, 0);
            this.btnFileDe.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileDe.Name = "btnFileDe";
            this.btnFileDe.Size = new System.Drawing.Size(33, 26);
            this.btnFileDe.TabIndex = 11;
            this.btnFileDe.UseVisualStyleBackColor = false;
            // 
            // btnCreateProblem
            // 
            this.btnCreateProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateProblem.BackColor = System.Drawing.Color.LightGray;
            this.btnCreateProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProblem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateProblem.Location = new System.Drawing.Point(714, 48);
            this.btnCreateProblem.Name = "btnCreateProblem";
            this.btnCreateProblem.Size = new System.Drawing.Size(110, 33);
            this.btnCreateProblem.TabIndex = 17;
            this.btnCreateProblem.Text = "Create Problem";
            this.btnCreateProblem.UseVisualStyleBackColor = false;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "test";
            this.Size = new System.Drawing.Size(1200, 700);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblems)).EndInit();
            this.gBNewProblem.ResumeLayout(false);
            this.gBNewProblem.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCreateContest;
        private System.Windows.Forms.DataGridView dataGridViewProblems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ouput;
        private System.Windows.Forms.GroupBox gBNewProblem;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProblemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnFileDe;
        private System.Windows.Forms.Button btnCreateProblem;
    }
}
