
namespace TestCode.View
{
    partial class Teacher
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelComponent = new System.Windows.Forms.Panel();
            this.btnManagerAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnManagerAccount);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 55);
            this.panel1.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.ForeColor = System.Drawing.Color.LightCyan;
            this.lblName.Location = new System.Drawing.Point(853, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(245, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelComponent
            // 
            this.panelComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelComponent.Location = new System.Drawing.Point(0, 55);
            this.panelComponent.Name = "panelComponent";
            this.panelComponent.Size = new System.Drawing.Size(1184, 706);
            this.panelComponent.TabIndex = 20;
            // 
            // btnManagerAccount
            // 
            this.btnManagerAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManagerAccount.FlatAppearance.BorderSize = 0;
            this.btnManagerAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagerAccount.Image = global::TestCode.Properties.Resources.user__1___1_;
            this.btnManagerAccount.Location = new System.Drawing.Point(1106, 17);
            this.btnManagerAccount.Name = "btnManagerAccount";
            this.btnManagerAccount.Size = new System.Drawing.Size(25, 25);
            this.btnManagerAccount.TabIndex = 6;
            this.btnManagerAccount.UseVisualStyleBackColor = true;
            this.btnManagerAccount.Click += new System.EventHandler(this.btnManagerAccount_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = global::TestCode.Properties.Resources.logout_offical;
            this.btnLogOut.Location = new System.Drawing.Point(1145, 17);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(25, 25);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelComponent);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(870, 557);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teacher_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManagerAccount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelComponent;
        private System.Windows.Forms.Button btnLogOut;
    }
}