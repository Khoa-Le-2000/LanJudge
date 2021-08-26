using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCode.Controller;
using TestCode.Model;

namespace TestCode.View.UseControls
{
    public partial class Teacher_CreateContest : UserControl
    {
        private Teacher FrmTeacher;
        private List<Problem> problems = new List<Problem>();

        public Teacher_CreateContest(Teacher frmTeacher)
        {
            InitializeComponent();
            FrmTeacher = frmTeacher;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           if (panelProblem.Visible == false)
            {
                panelProblem.Visible = true;
            }
           else
            {
                panelProblem.Visible = false;
            }
        }

        private void btnCreateContest_Click(object sender, EventArgs e)
        {
            FrmTeacher.showCreateContest();
        }

        private void resetTextBox()
        {
            txtProblemName.Text = "";
            txtContent.Text = "";
            txtInput.Text = "";
            txtOutput.Text = "";
        }
      
        private void btnInput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            txtInput.Text = folderBrowserDialog.SelectedPath;

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            txtOutput.Text = folderBrowserDialog.SelectedPath;

        }

        private void btnFileDe_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "pdf fomat (*.pdf)|*.pdf";

            DialogResult dialogResult = openFileDialog.ShowDialog();
            txtContent.Text = openFileDialog.FileName;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtProblemName.Text == "")
            {
                MessageBox.Show("Problem name not empty");
                return;
            }

            if (txtContent.Text == "")
            {
                MessageBox.Show("Content not empty");
                return;
            }

            if (txtOutput.Text == "")
            {
                MessageBox.Show("Output not empty");
                return;
            }

            if (btnCreate.Text == "CREATE PROBLEM")
            {
                foreach (DataGridViewRow row in dataGridViewProblems.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToUpper() == txtProblemName.Text.ToUpper())
                    {
                        MessageBox.Show("Problem is existed");
                        return;
                    }
                }

                dataGridViewProblems.Rows.Add(txtProblemName.Text, txtContent.Text, txtInput.Text, txtOutput.Text);
                problems.Add(new Problem(txtProblemName.Text, txtContent.Text, new List<TestCase> { new TestCase(txtInput.Text == "" ? null : txtInput.Text, txtOutput.Text) }));
                resetTextBox();
            }
            else
            {
                dataGridViewProblems.Rows[index].Cells[0].Value = txtProblemName.Text;
                dataGridViewProblems.Rows[index].Cells[1].Value = txtContent.Text;
                dataGridViewProblems.Rows[index].Cells[2].Value = txtInput.Text;
                dataGridViewProblems.Rows[index].Cells[3].Value = txtOutput.Text;

                resetTextBox();
                btnCreate.Text = "CREATE PROBLEM";
            }
        }

        private void dataGridViewProblems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure to this problem?", "Delete problem", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewProblems.Rows)
                    {
                        if (row.Cells[4].Selected)
                            dataGridViewProblems.Rows.Remove(row);
                    }

                }
            }
        }
        private int index;
        private void dataGridViewProblems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 0)
            {
                txtProblemName.Text = dataGridViewProblems.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtContent.Text = dataGridViewProblems.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtInput.Text = dataGridViewProblems.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtOutput.Text = dataGridViewProblems.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnCreate.Text = "Edit Problem";
                index = e.RowIndex;
            }
        }

        private void btnCreateContest_Click_1(object sender, EventArgs e)
        {
            if (txtContestName.Text == "")
            {
                MessageBox.Show("ContestName not empty!");
                return;
            }

            Test test = new Test(txtContestName.Text, int.Parse(txtTime.Text),DateTime.Parse(dateTimePicker1.Value.ToString()), problems);

            CltTest cltTest = new CltTest();
            test.TestId = cltTest.requestTestId(test);

            int res = cltTest.addTest(cltTest.createTest(test.TestId, problems));

            if(res == 1)
            {
                MessageBox.Show("Create Contest successful.");
                resetTextBox();
                txtContestName.Text = "";
                dataGridViewProblems.Rows.Clear();
                txtTime.Value = 0;
                dateTimePicker1.Value = DateTime.Now;
                problems.Clear();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
