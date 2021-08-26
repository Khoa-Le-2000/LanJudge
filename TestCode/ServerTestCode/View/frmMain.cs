using ServerTestCode.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTestCode.View
{
    public partial class frmMain : Form
    {
        private frmLogin FrmLogin;
        public frmMain(frmLogin frm, string userName)
        {
            InitializeComponent();
            FrmLogin = frm;
            home.timerStart();
            home.FrmMain = this;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            home.timerStop();
        }
    }
}
