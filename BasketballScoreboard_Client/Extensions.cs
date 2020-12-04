using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballScoreboard_Client
{
    static class Extensions
    {
        public static void InvokeIfRequired(this Control control, MethodInvoker action)
        {
            if (control.InvokeRequired) control.Invoke(action);
            else action();
        }

        public static void ControlsEnabled(Control[] controls, bool enabled)
        {
            foreach (Control control in controls)
                control.Enabled = enabled;
        }
    }
}
