
namespace TestCode.View.UseControls
{
    partial class Student_Submit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Submit));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProblemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnTaiFile = new System.Windows.Forms.Button();
            this.gBResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSubmitOfProblem = new System.Windows.Forms.Button();
            this.txtShowFile = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnProblem = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gBResult.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lblProblemName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.gBResult);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnSubmitOfProblem);
            this.panel2.Controls.Add(this.txtShowFile);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(107, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 648);
            this.panel2.TabIndex = 19;
            // 
            // lblProblemName
            // 
            this.lblProblemName.AutoSize = true;
            this.lblProblemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemName.Location = new System.Drawing.Point(79, 84);
            this.lblProblemName.Name = "lblProblemName";
            this.lblProblemName.Size = new System.Drawing.Size(46, 18);
            this.lblProblemName.TabIndex = 14;
            this.lblProblemName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Problem:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtFile);
            this.panel1.Controls.Add(this.btnTaiFile);
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 30);
            this.panel1.TabIndex = 12;
            // 
            // txtFile
            // 
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile.Location = new System.Drawing.Point(0, 0);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(204, 28);
            this.txtFile.TabIndex = 5;
            // 
            // btnTaiFile
            // 
            this.btnTaiFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTaiFile.FlatAppearance.BorderSize = 0;
            this.btnTaiFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiFile.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiFile.Image")));
            this.btnTaiFile.Location = new System.Drawing.Point(204, 0);
            this.btnTaiFile.Name = "btnTaiFile";
            this.btnTaiFile.Size = new System.Drawing.Size(24, 28);
            this.btnTaiFile.TabIndex = 4;
            this.btnTaiFile.UseVisualStyleBackColor = true;
            this.btnTaiFile.Click += new System.EventHandler(this.btnTaiFile_Click);
            // 
            // gBResult
            // 
            this.gBResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBResult.Controls.Add(this.txtResult);
            this.gBResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBResult.Location = new System.Drawing.Point(0, 418);
            this.gBResult.Name = "gBResult";
            this.gBResult.Size = new System.Drawing.Size(1026, 156);
            this.gBResult.TabIndex = 10;
            this.gBResult.TabStop = false;
            this.gBResult.Text = "Result";
            this.gBResult.Visible = false;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Location = new System.Drawing.Point(6, 21);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(1020, 129);
            this.txtResult.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            this.panel4.TabIndex = 7;
            // 
            // btnSubmitOfProblem
            // 
            this.btnSubmitOfProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitOfProblem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSubmitOfProblem.FlatAppearance.BorderSize = 0;
            this.btnSubmitOfProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitOfProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOfProblem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmitOfProblem.Location = new System.Drawing.Point(924, 110);
            this.btnSubmitOfProblem.Name = "btnSubmitOfProblem";
            this.btnSubmitOfProblem.Size = new System.Drawing.Size(102, 28);
            this.btnSubmitOfProblem.TabIndex = 6;
            this.btnSubmitOfProblem.Text = "Submit";
            this.btnSubmitOfProblem.UseVisualStyleBackColor = false;
            this.btnSubmitOfProblem.Click += new System.EventHandler(this.btnSubmitOfProblem_Click);
            // 
            // txtShowFile
            // 
            this.txtShowFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShowFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowFile.Location = new System.Drawing.Point(0, 156);
            this.txtShowFile.Multiline = true;
            this.txtShowFile.Name = "txtShowFile";
            this.txtShowFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShowFile.Size = new System.Drawing.Size(1026, 237);
            this.txtShowFile.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.btnProblem);
            this.panel3.Location = new System.Drawing.Point(0, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 30);
            this.panel3.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(114, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 30);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnProblem
            // 
            this.btnProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProblem.BackColor = System.Drawing.Color.LightGray;
            this.btnProblem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProblem.FlatAppearance.BorderSize = 0;
            this.btnProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProblem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProblem.Location = new System.Drawing.Point(0, 0);
            this.btnProblem.Name = "btnProblem";
            this.btnProblem.Size = new System.Drawing.Size(111, 30);
            this.btnProblem.TabIndex = 3;
            this.btnProblem.Text = "Problem";
            this.btnProblem.UseVisualStyleBackColor = false;
            this.btnProblem.Click += new System.EventHandler(this.btnProblem_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(231, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(823, 1);
            this.panel5.TabIndex = 15;
            // 
            // Student_Submit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(790, 722);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(790, 0);
            this.Name = "Student_Submit";
            this.Size = new System.Drawing.Size(1226, 748);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBResult.ResumeLayout(false);
            this.gBResult.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProblemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnTaiFile;
        private System.Windows.Forms.GroupBox gBResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSubmitOfProblem;
        private System.Windows.Forms.TextBox txtShowFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnProblem;
        private System.Windows.Forms.Panel panel5;
    }
}
