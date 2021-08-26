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

namespace TestCode.View.UseControls
{
    public partial class Student_Question : UserControl
    {
        private Student FrmStudent;
        public int ProblemId;
        public string ProblemName;
        public Student_Question(Student frmStudent)
        {
            InitializeComponent();
            FrmStudent = frmStudent;
        }

        public void loadContest(int problemId, string problemName)
        {
            ProblemId = problemId;
            ProblemName = problemName;
            CltProblem cltProblem = new CltProblem();
            axAcroPDF.setShowToolbar(false);
            axAcroPDF.setPageMode("none");
            axAcroPDF.LoadFile(cltProblem.getProblemContent(ProblemId));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FrmStudent.showSubmit(ProblemId, ProblemName);
        }

        private void btnProblem_Click(object sender, EventArgs e)
        {

        }
    }
}
