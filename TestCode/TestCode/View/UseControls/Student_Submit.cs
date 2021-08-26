using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCode.Controller;
using TestCode.Model;

namespace TestCode.View.UseControls
{
    public partial class Student_Submit : UserControl
    {
        public static int Index = -1;
        private Student FrmStudent;
        private int AccountId;
        private int ProblemId;
        private string ProblemName;
        private Loading loading;

        public Student_Submit(Student frmStudent)
        {
            InitializeComponent();
            FrmStudent = frmStudent;
            CltProblem cltProblem = new CltProblem();
            loading = new Loading();
            this.Controls.Add(loading);

            loading.Dock = DockStyle.Fill;
            
            loading.BringToFront();
            loading.Hide();
            //Index = index;
            //CltTest cltTest = new CltTest();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void storeData(int accoutId, int problemId, string problemName)
        {
            AccountId = accoutId;
            ProblemId = problemId;
            ProblemName = problemName;
            lblProblemName.Text = ProblemName;
        }

        private void btnProblem_Click(object sender, EventArgs e)
        { 
            FrmStudent.showQuestion(ProblemId, ProductName);
        }

        private void btnTaiFile_Click(object sender, EventArgs e)
        {
            string oSelectedFile = "";
            System.Windows.Forms.OpenFileDialog oDlg = new System.Windows.Forms.OpenFileDialog();
            if (System.Windows.Forms.DialogResult.OK == oDlg.ShowDialog())
            {
                oSelectedFile = oDlg.FileName;

                // Do whatever you want with oSelectedFile
                txtFile.Text = oSelectedFile;
                using (StreamReader sr = new StreamReader(oSelectedFile))
                {
                    string line;
                    txtShowFile.Text = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        txtShowFile.Text = txtShowFile.Text + Environment.NewLine + line;
                    }
                }
            }

        }

        private void btnSubmitOfProblem_Click(object sender, EventArgs e)
        {
            if(txtFile.Text == "")
            {
                MessageBox.Show("Please choose file.");
                return;
            }
            gBResult.Show();
            loading.Show();

            Thread thread = new Thread(submit);
            thread.IsBackground = true;
            thread.Start();
        }

        private void submit()
        {
            CltSubmission cltSubmission = new CltSubmission();
            Submission submission = cltSubmission.submit(txtFile.Text, AccountId, ProblemId);
            txtResult.Text = submission.Result;
            loading.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //CltTest cltTest = new CltTest();
            //if (Index + 1 < cltTest.loadTest().Count)
            //{
            //    Index++;
            //    //lblProblemName.Text
            //}
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //if (Index - 1 >= 0)
            //{
            //    Index--;
            //    lblProblemName.Text 
            //}
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
