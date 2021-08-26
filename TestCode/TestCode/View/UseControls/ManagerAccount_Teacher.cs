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
    public partial class ManagerAccount_Teacher : UserControl
    {
        private Teacher FrmTeacher;
        private Account Account;
        public ManagerAccount_Teacher(Teacher frmTeacher)
        {
            InitializeComponent();
            FrmTeacher = frmTeacher;
        }
        public void SetAccount(Account account)
        {
            Account = account;
            txtFullName.Text = Account.FullName;
            txtUserName.Text = Account.UserName;
        }

        private void btnChangPassword_Click(object sender, EventArgs e)
        {
            if(panelChangePassword.Visible == false)
            {
                panelChangePassword.Visible = true;
                btnSave.Location = new Point(12, 464);
                panelChangePassword.Location = new Point(12, 230);
            }
            else if(panelChangePassword.Visible == true)
            {
                panelChangePassword.Visible = false;
                btnSave.Location = new Point(12, 230);
                panelChangePassword.Location = new Point(12, 245);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!panelChangePassword.Visible)
            {
                CltAccount cltAccount = new CltAccount();
                int res = cltAccount.changeFullName(Account.AccountID, txtFullName.Text);
                if (res == 1)
                {
                    MessageBox.Show("Full name changed.");
                    FrmTeacher.UpdateName(txtFullName.Text);
                }
            }
            else
            {
                if (txtCurrentPass.Text == "")
                {
                    MessageBox.Show("Current password not empty");
                    return;
                }

                if (txtNewPass.Text == "")
                {
                    MessageBox.Show("New password not empty");
                    return;
                }

                if (txtNewPass.Text != txtNewPassAgain.Text)
                {
                    MessageBox.Show("Error New password again.");
                    return;
                }

                CltAccount cltAccount = new CltAccount();
                cltAccount.changeFullName(Account.AccountID, txtFullName.Text);
                int res2 = cltAccount.changePassword(Account.AccountID, txtCurrentPass.Text, txtNewPass.Text);

                switch (res2)
                {
                    case 1:
                        MessageBox.Show("Change information successful!");
                        txtCurrentPass.Text = "";
                        txtNewPass.Text = "";
                        txtNewPassAgain.Text = "";
                        panelChangePassword.Visible = false;
                        btnSave.Location = new Point(12, 228);
                        panelChangePassword.Location = new Point(12, 296);
                        break;

                    case -2:
                        MessageBox.Show("Password incorrect!");
                        break;
                }
            }
        }
    }
}
