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

using System.Data.SqlClient;

namespace ServerTestCode.View.UserControls
{
    public partial class ManagerAccount : UserControl
    {
        public ManagerAccount()
        {
            InitializeComponent();
            loadAccount();
        }
       
        private void loadAccount()
        {
            CltAccount cltAccount = new CltAccount();
            dataGridViewAccount.DataSource = cltAccount.loadAccount();           
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                CltAccount cltAccount = new CltAccount();
                dataGridViewAccount.DataSource = cltAccount.searchAccount(txtSearch.Text);
                txtSearch.Text = "";
            }
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            panelCreateNewAccount.Visible = true;
            btnCreateAccount.Text = "Create Account";
            txtUserName.ReadOnly = false;
            txtUserName.Text = "";
            txtPassword.Text = "";
            cmbPermission.Text = "";
            txtFullName.Text = "";
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (btnCreateAccount.Text == "Create Account")
            {
                createAccount();

            } else
            {
                updateAccount();
            }
        }
       
        private void createAccount()
        {
            if (txtUserName.Text == "" || txtPassword.Text == "" || cmbPermission.Text == "" || txtFullName.Text == "")
            {
                MessageBox.Show("Input not empty");
                return;
            }


            CltAccount cltAccount = new CltAccount();
            int res = cltAccount.addAccount(txtUserName.Text, txtPassword.Text, txtFullName.Text, cmbPermission.Text);
            if (res == -1)
            {
                MessageBox.Show("UserName exists");
                txtUserName.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Successful create!");
                loadAccount();
                txtUserName.Text = "";
                txtPassword.Text = "";
                cmbPermission.Text = "";
                txtFullName.Text = "";
            }
        }
        

        private void updateAccount()
        {
            
            if (txtUserName.Text == "" || txtPassword.Text == "" || cmbPermission.Text == "" || txtFullName.Text == "")
            {
                MessageBox.Show("Input not empty");
                return;
            }
            CltAccount cltAccount = new CltAccount();
           
            int res = cltAccount.updateAccount(int.Parse(lblVisible.Text), txtUserName.Text, txtPassword.Text, txtFullName.Text, cmbPermission.Text);
            if (res == -1)
            {
                MessageBox.Show("UserName exists");
                txtUserName.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Successful update!");
                loadAccount();
                txtUserName.Text = "";
                txtPassword.Text = "";
                cmbPermission.Text = "";
                txtFullName.Text = "";

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewAccount.Rows)
            {
                
                if (row.Cells[0].Selected)
                {
                    DialogResult d;
                    d = MessageBox.Show("Are you delete this account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        CltAccount cltAccount = new CltAccount();
                        int res = cltAccount.deleteAccount(int.Parse(row.Cells[0].Value.ToString()));
                        if (res == 1)
                        {
                            MessageBox.Show("This account was deleted");
                            loadAccount();
                            return;
                        }
                        else if(res == -2)
                        {
                            MessageBox.Show("Account have a lot submission!");
                            return;
                        }
                    }
                }
            }
        }

        private void dataGridViewAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelCreateNewAccount.Visible = true;
            txtUserName.ReadOnly = true;
            lblTitle.Text = "Edit Account";
            btnCreateAccount.Text = "Edit Account";
            txtUserName.Text = dataGridViewAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dataGridViewAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtFullName.Text = dataGridViewAccount.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbPermission.Text = dataGridViewAccount.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblVisible.Text = dataGridViewAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void lblManagerAccount_Click(object sender, EventArgs e)
        {
            loadAccount();
        }
    }
}
