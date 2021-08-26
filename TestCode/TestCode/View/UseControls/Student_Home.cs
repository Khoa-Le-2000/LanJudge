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
    public partial class Student_Home : UserControl
    {
        private Student FrmStudent;
        public Student_Home(Student frmStudent)
        {
            InitializeComponent();
            FrmStudent = frmStudent;
        }
        private List<Test> tests;
        public void Reload()
        {
            loadTest();
            loadTestComing();
        }
        private void loadTest()
        {
            CltTest cltTest = new CltTest();
            tests = cltTest.loadTest();
            dataGridViewContest.Rows.Clear();
            foreach(Test test in tests)
            {
                    dataGridViewContest.Rows.Add(test.TestId, test.TestName, test.TimeTest, test.TimeStart);
            }
        }
        private void loadTestComing()
        {
            CltTest cltTest = new CltTest();
            dataGridViewContesting.Rows.Clear();
            foreach (Test test in tests)
            {
                if (test.TimeStart < DateTime.Now && test.TimeStart.AddMinutes(test.TimeTest) > DateTime.Now)
                    dataGridViewContesting.Rows.Add(test.TestId, test.TestName, test.TimeTest, test.TimeStart);
            }
        }
        private void txtSearch_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) return;
            bool flag = false;
            dataGridViewContest.Rows.Clear();

            foreach (Test test in tests)
            {
                if (test.TestId.ToString().ToUpper() == txtSearch.Text.ToUpper() || test.TestName.ToUpper().Contains(txtSearch.Text.ToUpper()))
                {
                    dataGridViewContest.Rows.Add(test.TestId, test.TestName, test.TimeTest, test.TimeStart);
                    flag = true;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Contest is not exist");
            }
        }

        private void dataGridViewContest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DateTime.Parse(dataGridViewContest.Rows[e.RowIndex].Cells[3].Value.ToString()) > DateTime.Now)
            {
                MessageBox.Show("Contest is comming...");
                return;
            }

            FrmStudent.showTime(DateTime.Parse(dataGridViewContest.Rows[e.RowIndex].Cells[3].Value.ToString()),
                                int.Parse(dataGridViewContest.Rows[e.RowIndex].Cells[2].Value.ToString()));
            FrmStudent.showContest(int.Parse(dataGridViewContest.Rows[e.RowIndex].Cells[0].Value.ToString()), dataGridViewContest.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void dataGridViewContesting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmStudent.showTime(DateTime.Parse(dataGridViewContesting.Rows[e.RowIndex].Cells[3].Value.ToString()),
                                      int.Parse(dataGridViewContesting.Rows[e.RowIndex].Cells[2].Value.ToString()));
            FrmStudent.showContest(int.Parse(dataGridViewContesting.Rows[e.RowIndex].Cells[0].Value.ToString()), 
                                            dataGridViewContesting.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
