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
    public partial class ManagerProblem : UserControl
    {
        public ManagerProblem()
        {
            InitializeComponent();
            loadProblem();
        }
        private void loadProblem()
        {
            CltProblem cltProblem = new CltProblem();
            dataGridViewProblem.DataSource = cltProblem.loadProblem();
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CltProblem cltProblem = new CltProblem();
                dataGridViewProblem.DataSource = cltProblem.searchProblem(txtSearch.Text);
                txtSearch.Text = "";
            }
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProblem.Rows)
            {

                if (row.Cells[0].Selected)
                {
                    DialogResult d;
                    d = MessageBox.Show("Are you delete this problem?", "Delete Problem", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        CltProblem cltProblem = new CltProblem();
                        int res = cltProblem.deleteProblem(int.Parse(row.Cells[0].Value.ToString()));
                        if (res == 1)
                        {
                            MessageBox.Show("This problem was deleted");
                            loadProblem();
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

        private void lblManagerProblem_Click(object sender, EventArgs e)
        {
            loadProblem();
        }

        private void dataGridViewProblem_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelEditproblem.Visible = true;
            txtProblemID.Text = dataGridViewProblem.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProblemName.Text = dataGridViewProblem.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContent.Text = dataGridViewProblem.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTestID.Text = dataGridViewProblem.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnEditProblem_Click(object sender, EventArgs e)
        {
            if (txtProblemName.Text == "" || txtContent.Text == "")
            {
                MessageBox.Show("Input not empty");
                return;
            }
            CltProblem cltProblem = new CltProblem();

            int res = cltProblem.updateProblem(int.Parse(txtProblemID.Text), txtProblemName.Text, txtContent.Text, int.Parse(txtTestID.Text));

            MessageBox.Show("Successful update!");
            loadProblem();
            txtProblemID.Text = "";
            txtProblemName.Text = "";
            txtContent.Text = "";
            txtTestID.Text = "";
        }
    }
}
