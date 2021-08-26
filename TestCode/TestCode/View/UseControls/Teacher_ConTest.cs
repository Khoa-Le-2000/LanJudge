using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCode.Controller;
using TestCode.Model;

namespace TestCode.View.UseControls
{
    public partial class Teacher_Contest : UserControl
    {
        private Teacher FrmTeacher;
        private int TestId;
        private string TestName;
        private int TimeTest;
        private string TimeStart;
        public Teacher_Contest(Teacher frmTeacher)
        {
            InitializeComponent();
            FrmTeacher = frmTeacher;
        }
        public void loadData(int testId, string testName, int timeTest, string timeStart)
        {
            TestId = testId;
            dataGridViewProblems.Rows.Clear();
            CltProblem cltProblem = new CltProblem();
            List<Problem> problems = cltProblem.GetProblems(TestId);
            foreach (Problem problem in problems)
            {
                dataGridViewProblems.Rows.Add(problem.ProblemId, problem.ProblemName, problem.Content);
            }
            txtContestID.Text = testId.ToString();
            txtContestName.Text = testName;
            txtTime.Text = timeTest.ToString();
            dateTimeStart.Value = DateTime.Parse(timeStart.ToString());
                
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateContest_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateProblem_Click(object sender, EventArgs e)
        {
            //btnCreateProblem.BackColor = Color.DodgerBlue;
            //gBNewProblem.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmTeacher.showHome();
        }

        private void btnEditContest_Click(object sender, EventArgs e)
        {
            CltTest cltTest = new CltTest();
            Test test = new Test(int.Parse(txtContestID.Text.ToString()), txtContestName.Text,
                int.Parse(txtTime.Text.ToString()), DateTime.Parse(dateTimeStart.Value.ToString()), null);
            cltTest.editTest(test);
            MessageBox.Show("This contest is edited!");
        }

        private void txtContestName_KeyDown(object sender, KeyEventArgs e)
        {
            btnEditContest.BackColor = Color.DodgerBlue;
        }

        private void txtTime_KeyDown(object sender, KeyEventArgs e)
        {
            btnEditContest.BackColor = Color.DodgerBlue;
        }
        private void dateTimeStart_KeyDown(object sender, KeyEventArgs e)
        {
            btnEditContest.BackColor = Color.DodgerBlue;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            FrmTeacher.showResult(int.Parse(txtContestID.Text));
        }
    }
    
}
