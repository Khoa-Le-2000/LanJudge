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
    public partial class Teacher_Home : UserControl
    {
        
        private Teacher FrmTeacher;
        public Teacher_Home(Teacher frmTeacher)
        {
            InitializeComponent();
            FrmTeacher = frmTeacher;
        }
        private List<Test> tests;
        public void loadTest()
        {
            dataGridViewContest.Rows.Clear();
            CltTest cltTest = new CltTest();
            tests = cltTest.loadTest();
            foreach (Test test in tests)
            {
                dataGridViewContest.Rows.Add(test.TestId, test.TestName, test.TimeTest, test.TimeStart);
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
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
            if(e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 5)
            {
                FrmTeacher.showContest(int.Parse(dataGridViewContest.Rows[e.RowIndex].Cells[0].Value.ToString()),
                dataGridViewContest.Rows[e.RowIndex].Cells[1].Value.ToString(),
                int.Parse(dataGridViewContest.Rows[e.RowIndex].Cells[2].Value.ToString()),
                dataGridViewContest.Rows[e.RowIndex].Cells[3].Value.ToString());
            } 
            else if (e.ColumnIndex == 6)
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure to delete?", "Delete the Contest", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    CltTest cltTest = new CltTest();
                    int res = cltTest.deleteTest(int.Parse(dataGridViewContest.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    if (res == 1)
                    {
                        MessageBox.Show("Contest deleted");
                        loadTest();
                    }
                    else if(res < 0)
                    {
                        MessageBox.Show("Contest can't delete!");
                    }
                }       
            }
            else if(e.ColumnIndex == 4)
            {
                FrmTeacher.showResult(int.Parse(dataGridViewContest.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmTeacher.showCreateContest();
        }

        private void txtSearch_MouseUp(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

     
        private void lblContest_Click(object sender, EventArgs e)
        {
            loadTest();
            panelSearch.Visible = true;
        }
    }
}
