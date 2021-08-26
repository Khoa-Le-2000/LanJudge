
namespace TestCode.View.UseControls
{
    partial class Teacher_CreateContest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_CreateContest));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gB = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContestName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProblem = new System.Windows.Forms.Panel();
            this.dataGridViewProblems = new System.Windows.Forms.DataGridView();
            this.ProblemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ouput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gBNewProblem = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProblemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnFileDe = new System.Windows.Forms.Button();
            this.txtListOfProblem = new System.Windows.Forms.Label();
            this.btnCreateContest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.gB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).BeginInit();
            this.panelProblem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblems)).BeginInit();
            this.gBNewProblem.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.gB);
            this.panel2.Controls.Add(this.panelProblem);
            this.panel2.Controls.Add(this.btnCreateContest);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(104, 28);
            this.panel2.MinimumSize = new System.Drawing.Size(1000, 905);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 928);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(941, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(57, 1);
            this.panel4.TabIndex = 32;
            // 
            // gB
            // 
            this.gB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB.Controls.Add(this.txtTime);
            this.gB.Controls.Add(this.dateTimePicker1);
            this.gB.Controls.Add(this.label4);
            this.gB.Controls.Add(this.label2);
            this.gB.Controls.Add(this.txtContestName);
            this.gB.Controls.Add(this.label1);
            this.gB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB.Location = new System.Drawing.Point(0, 74);
            this.gB.MinimumSize = new System.Drawing.Size(1000, 175);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(1000, 175);
            this.gB.TabIndex = 30;
            this.gB.TabStop = false;
            this.gB.Text = "NEW CONTEST";
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(234, 90);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(151, 24);
            this.txtTime.TabIndex = 10;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(554, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 24);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time start:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time:";
            // 
            // txtContestName
            // 
            this.txtContestName.AcceptsReturn = true;
            this.txtContestName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContestName.Location = new System.Drawing.Point(234, 36);
            this.txtContestName.Name = "txtContestName";
            this.txtContestName.Size = new System.Drawing.Size(573, 24);
            this.txtContestName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contest Name:";
            // 
            // panelProblem
            // 
            this.panelProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProblem.Controls.Add(this.dataGridViewProblems);
            this.panelProblem.Controls.Add(this.gBNewProblem);
            this.panelProblem.Controls.Add(this.txtListOfProblem);
            this.panelProblem.Location = new System.Drawing.Point(0, 272);
            this.panelProblem.MinimumSize = new System.Drawing.Size(997, 617);
            this.panelProblem.Name = "panelProblem";
            this.panelProblem.Size = new System.Drawing.Size(997, 640);
            this.panelProblem.TabIndex = 31;
            this.panelProblem.Visible = false;
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
            this.dataGridViewProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProblems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProblemName,
            this.Content,
            this.Input,
            this.Ouput,
            this.Delete});
            this.dataGridViewProblems.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewProblems.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProblems.Name = "dataGridViewProblems";
            this.dataGridViewProblems.ReadOnly = true;
            this.dataGridViewProblems.RowHeadersVisible = false;
            this.dataGridViewProblems.RowHeadersWidth = 51;
            this.dataGridViewProblems.RowTemplate.Height = 24;
            this.dataGridViewProblems.Size = new System.Drawing.Size(997, 221);
            this.dataGridViewProblems.TabIndex = 20;
            this.dataGridViewProblems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProblems_CellClick);
            this.dataGridViewProblems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProblems_CellDoubleClick);
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
            // Input
            // 
            this.Input.DataPropertyName = "Input";
            this.Input.HeaderText = "Input";
            this.Input.MinimumWidth = 6;
            this.Input.Name = "Input";
            this.Input.ReadOnly = true;
            // 
            // Ouput
            // 
            this.Ouput.HeaderText = "Output";
            this.Ouput.Name = "Ouput";
            this.Ouput.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::TestCode.Properties.Resources.cancel;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 63;
            // 
            // gBNewProblem
            // 
            this.gBNewProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBNewProblem.Controls.Add(this.btnCreate);
            this.gBNewProblem.Controls.Add(this.panel5);
            this.gBNewProblem.Controls.Add(this.panel6);
            this.gBNewProblem.Controls.Add(this.label5);
            this.gBNewProblem.Controls.Add(this.label3);
            this.gBNewProblem.Controls.Add(this.txtProblemName);
            this.gBNewProblem.Controls.Add(this.label6);
            this.gBNewProblem.Controls.Add(this.label7);
            this.gBNewProblem.Controls.Add(this.panel1);
            this.gBNewProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBNewProblem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gBNewProblem.Location = new System.Drawing.Point(3, 284);
            this.gBNewProblem.Name = "gBNewProblem";
            this.gBNewProblem.Size = new System.Drawing.Size(992, 328);
            this.gBNewProblem.TabIndex = 33;
            this.gBNewProblem.TabStop = false;
            this.gBNewProblem.Text = "NEW PROBLEM";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(224, 268);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(474, 29);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "CREATE PROBLEM";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtInput);
            this.panel5.Controls.Add(this.btnInput);
            this.panel5.Location = new System.Drawing.Point(225, 154);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(472, 28);
            this.panel5.TabIndex = 16;
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(437, 26);
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
            this.btnInput.Location = new System.Drawing.Point(437, 0);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(33, 26);
            this.btnInput.TabIndex = 11;
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtOutput);
            this.panel6.Controls.Add(this.btnOutput);
            this.panel6.Location = new System.Drawing.Point(224, 214);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(472, 28);
            this.panel6.TabIndex = 16;
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(437, 26);
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
            this.btnOutput.Location = new System.Drawing.Point(437, 0);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(2);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(33, 26);
            this.btnOutput.TabIndex = 11;
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(128, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Output:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(137, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input:";
            // 
            // txtProblemName
            // 
            this.txtProblemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProblemName.Location = new System.Drawing.Point(225, 40);
            this.txtProblemName.Name = "txtProblemName";
            this.txtProblemName.Size = new System.Drawing.Size(472, 24);
            this.txtProblemName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(128, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Content:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(107, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Problem Name:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.btnFileDe);
            this.panel1.Location = new System.Drawing.Point(226, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 28);
            this.panel1.TabIndex = 15;
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(437, 26);
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
            this.btnFileDe.Location = new System.Drawing.Point(437, 0);
            this.btnFileDe.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileDe.Name = "btnFileDe";
            this.btnFileDe.Size = new System.Drawing.Size(33, 26);
            this.btnFileDe.TabIndex = 11;
            this.btnFileDe.UseVisualStyleBackColor = false;
            this.btnFileDe.Click += new System.EventHandler(this.btnFileDe_Click);
            // 
            // txtListOfProblem
            // 
            this.txtListOfProblem.AutoSize = true;
            this.txtListOfProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListOfProblem.Location = new System.Drawing.Point(-3, 17);
            this.txtListOfProblem.Name = "txtListOfProblem";
            this.txtListOfProblem.Size = new System.Drawing.Size(132, 20);
            this.txtListOfProblem.TabIndex = 0;
            this.txtListOfProblem.Text = "List Of Problem";
            // 
            // btnCreateContest
            // 
            this.btnCreateContest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateContest.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateContest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateContest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateContest.Location = new System.Drawing.Point(824, 20);
            this.btnCreateContest.Name = "btnCreateContest";
            this.btnCreateContest.Size = new System.Drawing.Size(117, 32);
            this.btnCreateContest.TabIndex = 28;
            this.btnCreateContest.Text = "Create Contest";
            this.btnCreateContest.UseVisualStyleBackColor = false;
            this.btnCreateContest.Click += new System.EventHandler(this.btnCreateContest_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(711, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 27;
            this.button1.Text = "Create Problem";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Delete";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::TestCode.Properties.Resources.cancel;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(105, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 1);
            this.panel3.TabIndex = 4;
            // 
            // Teacher_CreateContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1111, 900);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1130, 0);
            this.Name = "Teacher_CreateContest";
            this.Size = new System.Drawing.Size(1113, 889);
            this.panel2.ResumeLayout(false);
            this.gB.ResumeLayout(false);
            this.gB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).EndInit();
            this.panelProblem.ResumeLayout(false);
            this.panelProblem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblems)).EndInit();
            this.gBNewProblem.ResumeLayout(false);
            this.gBNewProblem.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContestName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateContest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelProblem;
        private System.Windows.Forms.GroupBox gBNewProblem;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProblemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnFileDe;
        private System.Windows.Forms.Label txtListOfProblem;
        private System.Windows.Forms.DataGridView dataGridViewProblems;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.NumericUpDown txtTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ouput;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}
