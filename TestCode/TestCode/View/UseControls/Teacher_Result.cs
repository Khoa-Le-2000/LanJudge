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
    public partial class Teacher_Result : UserControl
    {
        private Teacher FrmTeacher;
        public Teacher_Result(Teacher frmTeacher)
        {
            InitializeComponent();
            FrmTeacher = frmTeacher;
        }
        public void loadResult(int testId)
        {
            dataGridViewResult.Rows.Clear();
            CltResult cltResult = new CltResult();
            CltSubmission cltSubmission = new CltSubmission();
            Result result = cltResult.GetResult(0, testId);
            foreach (Submission submission in result.Submissions)
            {
                dataGridViewResult.Rows.Add(submission.AccountID, submission.ProblemName, submission.Result, submission.TimeRun, submission.NumOfTestCase, submission.TimeSubmit);
            }
        }

        private void dataGridViewResult_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewResult.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No records found.",
                    dataGridViewResult.Font, dataGridViewResult.ClientRectangle,
                    dataGridViewResult.ForeColor, dataGridViewResult.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
