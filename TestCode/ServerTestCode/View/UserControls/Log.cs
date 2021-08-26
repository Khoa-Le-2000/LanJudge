using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTestCode.View.UserControls
{
    public partial class Log : UserControl
    {
        private static List<string> textMessage = new List<string>();
        
        public Log()
        {
            InitializeComponent();
            loadMessage();
        }

        public void loadMessage()
        {
            txtLog.Text = "";
            foreach (string message in textMessage)
            {
                txtLog.AppendText(message + Environment.NewLine);
            }
            txtLog.ScrollToCaret();
        }

        public static void addMessage(string message)
        {
            if (textMessage.Count == 100)
                textMessage.Remove(textMessage[0]);
            textMessage.Add(message);
        }
    }
}
