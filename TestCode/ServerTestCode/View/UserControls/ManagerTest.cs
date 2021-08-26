using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerTestCode.Control;

namespace ServerTestCode.View.UserControls
{
    public partial class ManagerTest : UserControl
    {
        public ManagerTest()
        {
            InitializeComponent();
            loadTest();
        }
        private void loadTest()
        {
            CltTest cltTest = new CltTest();
            dataGridViewTest.DataSource = cltTest.loadTest();
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CltTest cltTest = new CltTest();
                dataGridViewTest.DataSource = cltTest.searchTest(txtSearch.Text);
                txtSearch.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewTest.Rows)
            {

                if (row.Cells[0].Selected)
                {
                    DialogResult d;
                    d = MessageBox.Show("Are you delete this test?", "Delete Test", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        CltTest cltTest = new CltTest();
                        int res = cltTest.deleteTest(int.Parse(row.Cells[0].Value.ToString()));
                        if (res == 1)
                        {
                            MessageBox.Show("This test was deleted");
                            loadTest();
                            return;
                        }
                        else if (res == -2)
                        {
                            MessageBox.Show("Problem have a lot submission!");
                            return;
                        }
                    }
                }
            }
        }

        private void lblManagerTest_Click(object sender, EventArgs e)
        {
            loadTest();
        }

        private void dataGridViewTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelEditTest.Visible = true;
            txtTestID.Text = dataGridViewTest.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTestName.Text = dataGridViewTest.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTimeTest.Text = dataGridViewTest.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTimeStart.Text = dataGridViewTest.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnEditTest_Click(object sender, EventArgs e)
        {
            if (txtTestName.Text == "" || txtTimeTest.Text == "" || txtTimeStart.Text == "")
            {
                MessageBox.Show("Input not empty");
                return;
            }
            CltTest cltTest = new CltTest();

            int res = cltTest.updateTest(int.Parse(txtTestID.Text), txtTestName.Text, int.Parse(txtTimeTest.Text), DateTime.Parse(txtTimeStart.Text));

            MessageBox.Show("Successful update!");
            loadTest();
            txtTestID.Text = "";
            txtTestName.Text = "";
            txtTimeTest.Text = "";
            txtTimeStart.Text = "";

        }
    }
}
