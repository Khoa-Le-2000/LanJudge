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
    public partial class ManagerAdminAccount : UserControl
    {
        public ManagerAdminAccount()
        {
            InitializeComponent();
        }


        private void btnChangPassword_Click_1(object sender, EventArgs e)
        {
            panelChangePassword.Visible = true;
            btnSave.Location = new Point(13, 352);
            panelChangePassword.Location = new Point(13, 184);
        }

        private void ManagerAdminAccount_Load(object sender, EventArgs e)
        {          
            CltAccount cltAccount = new CltAccount();
            txtUserName.Text = CltAccount.Account.UserName;
            txtFullName.Text = CltAccount.Account.FullName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (panelChangePassword.Visible)
                changePassword();
            if (txtFullName.Text != CltAccount.Account.FullName)
                changeFullName();
        }

        private void changeFullName()
        {
            CltAccount cltAccount = new CltAccount();
            cltAccount.ChangeFullName(txtFullName.Text);
        }

        private void changePassword()
        {
            if (txtNewPassAgain.Text != txtNewPass.Text)
            {
                MessageBox.Show("New password and Re-type new password not same!");
                return;
            }

            CltAccount cltAccount = new CltAccount();
            int res = cltAccount.ChangePass(txtCurrentPass.Text, txtNewPass.Text);

            if (res == -2)
            {
                MessageBox.Show("Password incorrect");
                return;
            }

            if (res == 1)
            {
                MessageBox.Show("Password is changed");
                txtNewPass.Text = "";
                txtNewPassAgain.Text = "";
                txtCurrentPass.Text = "";
                panelChangePassword.Visible = false;
                btnSave.Location = new Point(12, 211);
            }
        }
    }
}
