
namespace TestCode.View
{
    partial class Student
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnManagerAccount = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnContest = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelComponent = new System.Windows.Forms.Panel();
            this.timeCountDown = new TestCode.View.UseControls.TimeCountDown();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.timeCountDown);
            this.panel1.Controls.Add(this.btnManagerAccount);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Controls.Add(this.btnContest);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 55);
            this.panel1.TabIndex = 18;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = global::TestCode.Properties.Resources.logout_offical;
            this.btnLogOut.Location = new System.Drawing.Point(1193, 19);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(25, 25);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnManagerAccount
            // 
            this.btnManagerAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManagerAccount.FlatAppearance.BorderSize = 0;
            this.btnManagerAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagerAccount.Image = global::TestCode.Properties.Resources.user__1___1_;
            this.btnManagerAccount.Location = new System.Drawing.Point(1155, 17);
            this.btnManagerAccount.Name = "btnManagerAccount";
            this.btnManagerAccount.Size = new System.Drawing.Size(25, 25);
            this.btnManagerAccount.TabIndex = 6;
            this.btnManagerAccount.UseVisualStyleBackColor = true;
            this.btnManagerAccount.Click += new System.EventHandler(this.btnManagerAccount_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.LightCyan;
            this.lblName.Location = new System.Drawing.Point(916, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(233, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.SteelBlue;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResult.Location = new System.Drawing.Point(430, 0);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(93, 55);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnContest
            // 
            this.btnContest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnContest.FlatAppearance.BorderSize = 0;
            this.btnContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContest.Location = new System.Drawing.Point(337, 0);
            this.btnContest.Name = "btnContest";
            this.btnContest.Size = new System.Drawing.Size(93, 55);
            this.btnContest.TabIndex = 2;
            this.btnContest.Text = "Contest";
            this.btnContest.UseVisualStyleBackColor = false;
            this.btnContest.Click += new System.EventHandler(this.btnContest_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(244, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(93, 55);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitle.Location = new System.Drawing.Point(8, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Practice Coding";
            // 
            // panelComponent
            // 
            this.panelComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelComponent.Location = new System.Drawing.Point(0, 55);
            this.panelComponent.Name = "panelComponent";
            this.panelComponent.Size = new System.Drawing.Size(1230, 678);
            this.panelComponent.TabIndex = 19;
            // 
            // timeCountDown
            // 
            this.timeCountDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeCountDown.Location = new System.Drawing.Point(699, 10);
            this.timeCountDown.Name = "timeCountDown";
            this.timeCountDown.Size = new System.Drawing.Size(102, 39);
            this.timeCountDown.TabIndex = 7;
            this.timeCountDown.Visible = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 733);
            this.Controls.Add(this.panelComponent);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(920, 557);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UseControls.TimeCountDown timeCountDown;
        private System.Windows.Forms.Button btnManagerAccount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnContest;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelComponent;
        private System.Windows.Forms.Button btnLogOut;
    }
}