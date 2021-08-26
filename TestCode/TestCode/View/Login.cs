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

namespace TestCode.View
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
            Model.Account account = cltAccount.CheckLogin(txtUserName.Text, txtPassword.Text);
           
            if (account == null)
            {
                lblError.Text = "User name or password incorrect";
                return;
            } 
            else
            {
                if (account.Permission == "Student")
                {
                    this.Hide();
                    Student student = new Student(this, account);
                    student.Show();
                    txtPassword.Text = "";
                    txtUserName.Text = "";
                    return;
                }
                else if(account.Permission == "Teacher")
                {
                    this.Hide();
                    Teacher teacher = new Teacher(this, account);
                    teacher.Show();
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    return;
                }
            }
        }
    }
}
