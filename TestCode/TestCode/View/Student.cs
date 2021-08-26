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
    public partial class Student : Form
    {
        private Login FrmLogin;
        private Student_Home student_Home;
        private Student_Contest student_Contest;
        private Student_Result student_Result;
        private Student_Question student_Question;
        private Student_Submit student_Submit;
        private ManagerAccount managerAccount;
        private Account Account;
        private int TestId = 0;
        public Student(Login frmLogin, Account account)
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
            student_Home = new Student_Home(this);
            panelComponent.Controls.Add(student_Home);
            student_Home.Dock = DockStyle.Fill;

            student_Contest = new Student_Contest(this);
            panelComponent.Controls.Add(student_Contest);
            student_Contest.Dock = DockStyle.Fill;

            student_Result = new Student_Result(this);
            panelComponent.Controls.Add(student_Result);
            student_Result.Dock = DockStyle.Fill;

            student_Question = new Student_Question(this);
            panelComponent.Controls.Add(student_Question);
            student_Question.Dock = DockStyle.Fill;

            student_Submit = new Student_Submit(this) ;
            panelComponent.Controls.Add(student_Submit);
            student_Submit.Dock = DockStyle.Fill;

            managerAccount = new ManagerAccount(this);
            panelComponent.Controls.Add(managerAccount);
            managerAccount.Dock = DockStyle.Fill;
        }

        public void UpdateName(string name)
        {
            Account.FullName = name;
            lblName.Text = name;
        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            timeCountDown.Stop();
            FrmLogin.Show();
        }
        private void CloseComponent()
        {
            student_Home.Hide();
            student_Contest.Hide();
            student_Result.Hide();
            student_Question.Hide();
            student_Submit.Hide();
            managerAccount.Hide();
        }
        public void showHome()
        {
            CloseComponent();
            student_Home.Reload();
            student_Home.Show();
        }
        public void showContest(int testId, string content)
        {
            CloseComponent();
            student_Contest.loadData(testId, content);
            student_Contest.Show();
            TestId = testId;
            resetBorder();
            btnContest.FlatAppearance.BorderSize = 1;
        }
        public void showResult()
        {
            CloseComponent();
            student_Result.storeData(Account.AccountID, TestId);
            student_Result.Show();
            student_Result.loadResult();
        }
        public void showQuestion(int problemId, string problemName)
        {
            CloseComponent();
            student_Question.loadContest(problemId, problemName);
            student_Question.Show();
        }
        public void showSubmit(int problemId, string problemName)
        {
            CloseComponent();
            student_Submit.storeData(Account.AccountID, problemId, problemName);
            student_Submit.Show();
        }

        public void showManagerAccount(int accountId)
        {
            CloseComponent();
            //managerAccount.storeData(accountId);
            managerAccount.Show();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            showResult();
            resetBorder();
            btnResult.FlatAppearance.BorderSize = 1;
        }
        private void resetBorder()
        {
            btnHome.FlatAppearance.BorderSize = 0;
            btnContest.FlatAppearance.BorderSize = 0;
            btnResult.FlatAppearance.BorderSize = 0;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            showHome();
            resetBorder();
            btnHome.FlatAppearance.BorderSize = 1;
        }

        private void btnContest_Click(object sender, EventArgs e)
        {
            CloseComponent();
            student_Contest.Show();
            resetBorder();
            btnContest.FlatAppearance.BorderSize = 1;
        }

        private void btnManagerAccount_Click(object sender, EventArgs e)
        {
            CloseComponent();
            managerAccount.SetAccount(Account);
            managerAccount.Show();
        }

        public void showTime(DateTime timeStart, int timeTest)
        {
            timeCountDown.SetData(timeStart, timeTest);
            timeCountDown.Run();
            timeCountDown.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
