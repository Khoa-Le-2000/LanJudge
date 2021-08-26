namespace ServerTestCode.View.UserControls
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnManAcc = new System.Windows.Forms.Button();
            this.btnManProblem = new System.Windows.Forms.Button();
            this.btnManAdAcc = new System.Windows.Forms.Button();
            this.btnManTest = new System.Windows.Forms.Button();
            this.btnLockOut = new System.Windows.Forms.Button();
            this.lblCpu = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(76, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 17);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Stopped";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPU";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(25, 72);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(170, 56);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Start/Stop Server";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "RAM";
            // 
            // btnManAcc
            // 
            this.btnManAcc.Location = new System.Drawing.Point(255, 72);
            this.btnManAcc.Name = "btnManAcc";
            this.btnManAcc.Size = new System.Drawing.Size(170, 56);
            this.btnManAcc.TabIndex = 5;
            this.btnManAcc.Text = "Manager Account";
            this.btnManAcc.UseVisualStyleBackColor = true;
            this.btnManAcc.Click += new System.EventHandler(this.btnManAcc_Click);
            // 
            // btnManProblem
            // 
            this.btnManProblem.Location = new System.Drawing.Point(497, 72);
            this.btnManProblem.Name = "btnManProblem";
            this.btnManProblem.Size = new System.Drawing.Size(170, 56);
            this.btnManProblem.TabIndex = 6;
            this.btnManProblem.Text = "Manager Problem";
            this.btnManProblem.UseVisualStyleBackColor = true;
            this.btnManProblem.Click += new System.EventHandler(this.btnManProblem_Click);
            // 
            // btnManAdAcc
            // 
            this.btnManAdAcc.Location = new System.Drawing.Point(25, 178);
            this.btnManAdAcc.Name = "btnManAdAcc";
            this.btnManAdAcc.Size = new System.Drawing.Size(170, 56);
            this.btnManAdAcc.TabIndex = 7;
            this.btnManAdAcc.Text = "Manager Admin Account";
            this.btnManAdAcc.UseVisualStyleBackColor = true;
            this.btnManAdAcc.Click += new System.EventHandler(this.btnManAdAcc_Click);
            // 
            // btnManTest
            // 
            this.btnManTest.Location = new System.Drawing.Point(255, 178);
            this.btnManTest.Name = "btnManTest";
            this.btnManTest.Size = new System.Drawing.Size(170, 56);
            this.btnManTest.TabIndex = 8;
            this.btnManTest.Text = "Manager Test";
            this.btnManTest.UseVisualStyleBackColor = true;
            this.btnManTest.Click += new System.EventHandler(this.btnManTest_Click);
            // 
            // btnLockOut
            // 
            this.btnLockOut.Location = new System.Drawing.Point(497, 178);
            this.btnLockOut.Name = "btnLockOut";
            this.btnLockOut.Size = new System.Drawing.Size(170, 56);
            this.btnLockOut.TabIndex = 9;
            this.btnLockOut.Text = "Lock Out";
            this.btnLockOut.UseVisualStyleBackColor = true;
            this.btnLockOut.Click += new System.EventHandler(this.btnLockOut_Click);
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu.ForeColor = System.Drawing.Color.Green;
            this.lblCpu.Location = new System.Drawing.Point(294, 20);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(35, 17);
            this.lblCpu.TabIndex = 10;
            this.lblCpu.Text = "---%";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.ForeColor = System.Drawing.Color.Green;
            this.lblRam.Location = new System.Drawing.Point(538, 20);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(47, 17);
            this.lblRam.TabIndex = 11;
            this.lblRam.Text = "--- MB";
            // 
            // timer
            // 
            this.timer.Interval = 800;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.btnLockOut);
            this.Controls.Add(this.btnManTest);
            this.Controls.Add(this.btnManAdAcc);
            this.Controls.Add(this.btnManProblem);
            this.Controls.Add(this.btnManAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(691, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnManAcc;
        private System.Windows.Forms.Button btnManProblem;
        private System.Windows.Forms.Button btnManAdAcc;
        private System.Windows.Forms.Button btnManTest;
        private System.Windows.Forms.Button btnLockOut;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Timer timer;
    }
}
