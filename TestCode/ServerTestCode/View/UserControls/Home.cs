using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using ServerTestCode.Control;

namespace ServerTestCode.View.UserControls
{
    public partial class Home : UserControl
    {
        private static string status = "Stopped";
        private static CltServer cltServer = new CltServer();
        public frmMain FrmMain;

        private PerformanceCounter cpuCounter = null;
        private PerformanceCounter ramCounter = null;

        public Home()
        {
            InitializeComponent();
            loadStatus();
        }

        private void loadStatus()
        {
            lblStatus.ForeColor = status == "Stopped" ? Color.Red : Color.Green;
            lblStatus.Text = status;
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        private void loadCPU()
        {
            dynamic counter = cpuCounter.NextValue();
            lblCpu.ForeColor = counter >= 80 ? Color.Red : Color.Green;
            lblCpu.Text = counter.ToString() + " %";

        }

        private void loadRAM()
        {
            lblRam.Text = ramCounter.NextValue() + "MB";
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Stopped")
            {
                cltServer.Connect();
                status = "Started";
                loadStatus();
            }
            else
            {
                cltServer.Close();
                status = "Stopped";
                loadStatus();
            }
        }

        private void btnManAcc_Click(object sender, EventArgs e)
        {
            frmComponents frm = new frmComponents(1, FrmMain);
            FrmMain.Hide();
            frm.Show();

        }

        private void btnManProblem_Click(object sender, EventArgs e)
        {
            frmComponents frm = new frmComponents(3, FrmMain);
            FrmMain.Hide();
            frm.Show();
        }

        private void btnManAdAcc_Click(object sender, EventArgs e)
        {
            frmComponents frm = new frmComponents(2, FrmMain);
            FrmMain.Hide();
            frm.Show();
        }

        private void btnManTest_Click(object sender, EventArgs e)
        {
            frmComponents frm = new frmComponents(4, FrmMain);
            FrmMain.Hide();
            frm.Show();
        }

        private void btnLockOut_Click(object sender, EventArgs e)
        {
            FrmMain.Close();
        }

        private Thread threadCPU;

        private void timer_Tick(object sender, EventArgs e)
        {
            loadCPU();
            loadRAM();
        }

        public void timerStart()
        {
            timer.Enabled = true;
            timer.Start();
        }

        public void timerStop()
        {
            timer.Stop();
            timer.Enabled = false;
        }
    }
}
