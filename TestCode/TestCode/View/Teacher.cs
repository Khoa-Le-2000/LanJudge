using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCode.Model;
using TestCode.View.UseControls;

namespace TestCode.View
{
    public partial class Teacher : Form
    {
        private Login FrmLogin;
        private Teacher_Home teacher_Home;
        private Teacher_Contest teacher_Contest;
        public Teacher_CreateContest teacher_CreateContest;
        private Teacher_Result teacher_Result;
        private ManagerAccount_Teacher managerAccount_Teacher;
        private Account Account;
        private int AccountId;
        private int TestId;

        public Teacher(Login frmLogin, Account account)
        {
            InitializeComponent();
            FrmLogin = frmLogin;
            InitComponent();
            showHome();
            lblName.Text = account.FullName;
            Account = account;
        }

        private void InitComponent()
        {
            teacher_Home = new Teacher_Home(this);
            panelComponent.Controls.Add(teacher_Home);
            teacher_Home.Dock = DockStyle.Fill;

            teacher_Contest = new Teacher_Contest(this);
            panelComponent.Controls.Add(teacher_Contest);
            teacher_Contest.Dock = DockStyle.Fill;

            teacher_CreateContest = new Teacher_CreateContest(this);
            panelComponent.Controls.Add(teacher_CreateContest);
            teacher_CreateContest.Dock = DockStyle.Fill;

            teacher_Result = new Teacher_Result(this);
            panelComponent.Controls.Add(teacher_Result);
            teacher_Result.Dock = DockStyle.Fill;

            managerAccount_Teacher = new ManagerAccount_Teacher(this);
            panelComponent.Controls.Add(managerAccount_Teacher);
            managerAccount_Teacher.Dock = DockStyle.Fill;
        }
        private void Teacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Show();
        }
        public void UpdateName(string name)
        {
            Account.FullName = name;
            lblName.Text = name;
        }
        private void CloseComponent()
        {
            teacher_Home.Hide();
            teacher_Contest.Hide();
            teacher_CreateContest.Hide();
            teacher_Result.Hide();
            managerAccount_Teacher.Hide();
        }
        public void showHome()
        {
            CloseComponent();
            teacher_Home.loadTest();
            teacher_Home.Show();
        }
        public void showContest(int testId, string testName, int timeTest, string timeStart)
        {
            CloseComponent();
            teacher_Contest.loadData(testId, testName, timeTest, timeStart);
            teacher_Contest.Show();
            TestId = testId;
        }
        public void showCreateContest()
        {
            CloseComponent();
            teacher_CreateContest.Show();
        }
        public void showResult(int testId)
        {
            CloseComponent();
            teacher_Result.Show();
            teacher_Result.loadResult(testId);
        }
        public void showManagerAccount_Teacher()
        {
            CloseComponent();
            managerAccount_Teacher.Show();
        }

        private void btnContest_Click(object sender, EventArgs e)
        {
            CloseComponent();
            teacher_Contest.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            showHome();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            showHome();
        }

        private void panelComponent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManagerAccount_Click(object sender, EventArgs e)
        {
            CloseComponent();
            managerAccount_Teacher.SetAccount(Account);
            managerAccount_Teacher.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
