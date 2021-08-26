using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCode
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            do
            {
                if (!Controller.CltClient.Connect())
                {
                    if (DialogResult.Cancel == MessageBox.Show("Error connect to server...", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                        break;
                }
                else
                {
                    Application.Run(new View.Login());
                    break;
                }
            } while (true);
        }
    }
}
