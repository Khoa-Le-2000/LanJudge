using ServerTestCode.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTestCode.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblError.Text = "";
            Console.WriteLine("Server waiting login administrator...");
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtUserName.Text == null)
            {
                lblError.Text = "User name not empty";
                return;
            }
            if (txtPassword.Text == "" || txtPassword.Text == null)
            {
                lblError.Text = "Password not empty";
                return;
            }
            CltAccount cltAccount = new CltAccount();
            Model.Account account = cltAccount.checkLoginAdmin(txtUserName.Text, txtPassword.Text);
            if (account == null)
            {
                lblError.Text = "User name or password incorrect";
                return;
            }
            else
            {
                if (account.Permission == "Admin")
                {
                    this.Hide();
                    frmMain frm = new frmMain(this, txtUserName.Text);
                    CltAccount.Account = account;
                    frm.Show();
                    txtPassword.Text = "";
                    txtUserName.Text = "";
                    Console.WriteLine($"Server login with account {txtUserName.Text} at {DateTime.Now.ToString()}");
                    return;
                }
                else
                {
                    lblError.Text = "You not permission to log in";
                    return;
                }
            }
        }
    }
}
