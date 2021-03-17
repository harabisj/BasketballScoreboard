using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballScoreboard_Server
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

            /**
             * At first run ConnectionForm
             */
            ConnectionForm connectionForm = new ConnectionForm();
            Application.Run(connectionForm);
            
            /**
             * If the IP has been selected in ConnectionForm, run MainForm
             */
            if (connectionForm.selectedIp != "")
            {
                Application.Run(new MainForm(connectionForm.selectedIp));
            }
        }
    }
}
