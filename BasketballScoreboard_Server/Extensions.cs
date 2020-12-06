using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballScoreboard_Server
{
    static class Extensions
    {
        public static void InvokeIfRequired(this Control control, MethodInvoker action)
        {
            if (control.InvokeRequired) control.Invoke(action);
            else action();
        }

        public static string GetIpOnly(string IpPort)
        {
            return IpPort.Split(':')[0];
        }
    }
}
