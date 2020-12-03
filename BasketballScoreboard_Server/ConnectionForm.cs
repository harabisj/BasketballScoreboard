using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace BasketballScoreboard_Server
{
    public partial class ConnectionForm : Form
    {
        public string selectedIp = "";

        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            /**
             * Fill the ListBox with available IPv4 addresses
             */
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in hostEntry.AddressList)
            {
                if (!ip.AddressFamily.ToString().Contains("V6"))
                    ipListBox.Items.Add(ip);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            /**
             * Save the selected IP to public property and close the form
             */
            selectedIp = ipListBox.SelectedItem.ToString();
            Close();
        }

        private void ipListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /**
             * Validate the ipListBox selection
             */
            startButton.Enabled = !(ipListBox.SelectedIndex == -1);
        }
    }
}
