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
    public partial class Student_Contest : UserControl
    {
        private Student FrmStudent;
        private int TestId;

        public Student_Contest(Student frmStudent)
        {
            InitializeComponent();
            FrmStudent = frmStudent;
        }

        public void loadData(int testId, string content)
        {
            dataGridViewProblems.Rows.Clear();
            TestId = testId;
            CltProblem cltProblem = new CltProblem();
            List<Problem> problems = cltProblem.GetProblems(TestId);
            foreach (Problem problem in problems)
            {
                dataGridViewProblems.Rows.Add(problem.ProblemId, problem.ProblemName, problem.Content, "haha");
            }
            txtContent.Text = content;
        }

        private void dataGridViewProblems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                FrmStudent.showQuestion(int.Parse(dataGridViewProblems.Rows[e.RowIndex].Cells[0].Value.ToString()), 
                    dataGridViewProblems.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }
    }
}
