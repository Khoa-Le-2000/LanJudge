using ServerTestCode.View.UserControls;
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
    public partial class frmComponents : Form
    {
        private frmMain FrmMain;
        public frmComponents(int comp, frmMain frmMain)
        {
            InitializeComponent();
            loadComponent(comp);
            FrmMain = frmMain;
        }

        private void loadComponent(int comp)
        {
            switch (comp)
            {
                case 1:
                    lblTitle.Text = "Manager Account";
                    ManagerAccount managerAccount = new ManagerAccount();
                    pnlComponents.Controls.Add(managerAccount);
                    managerAccount.Dock = DockStyle.Fill;
                    managerAccount.Show();
                    break;
                case 2:
                    lblTitle.Text = "Manager Admin Account";
                    ManagerAdminAccount managerAdminAccount = new ManagerAdminAccount();
                    pnlComponents.Controls.Add(managerAdminAccount);
                    managerAdminAccount.Dock = DockStyle.Fill;
                    managerAdminAccount.Show();
                    break;
                case 3:
                    lblTitle.Text = "Manager Problem";
                    ManagerProblem managerProblem = new ManagerProblem();
                    pnlComponents.Controls.Add(managerProblem);
                    managerProblem.Dock = DockStyle.Fill;
                    managerProblem.Show();
                    break;
                case 4:
                    lblTitle.Text = "Manager Test";
                    ManagerTest managerTest = new ManagerTest();
                    pnlComponents.Controls.Add(managerTest);
                    managerTest.Dock = DockStyle.Fill;
                    managerTest.Show();
                    break;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain.Show();
        }

        private void frmComponents_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.Show();
        }
    }
}
