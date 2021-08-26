using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCode.Controller;

namespace TestCode.View.UseControls
{
    public partial class TimeCountDown : UserControl
    {
        private DateTime TimeStart;
        private int TimeTest;
        private int timeRemain = 0;

        public TimeCountDown()
        {
            InitializeComponent();
            timer.Stop();
        }

        public void SetData(DateTime timeStart, int timeTest)
        {
            TimeStart = timeStart;
            TimeTest = timeTest;
            DateTime timeEnd = TimeStart.AddMinutes(TimeTest);
            TimeSpan timeSpan = timeEnd - DateTime.Now;
            timeRemain = (int)timeSpan.TotalSeconds;
        }

        public void Run()
        {
            timer.Start();
            lblTime.Visible = true;
            fillData();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void fillData()
        {
            int hour = timeRemain / 60;
            int minutes = timeRemain % 60;
            lblTime.Text = $"{hour.ToString("00")}:{minutes.ToString("00")}";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeRemain--;
            
            if (timeRemain <= 0)
            {
                lblTime.Visible = false;

                timer.Stop();

                MessageBox.Show("TimeOut");
                
            }
            fillData();
        }
    }
}
