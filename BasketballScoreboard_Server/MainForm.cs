using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballScoreboard_Server
{
    public partial class MainForm : Form
    {
        private ConnectionsManager connectionsManager;

        public MainForm(string ip)
        {
            InitializeComponent();

            /**
             * Create ConnectionsManager instance and start the server
             */
            connectionsManager = new ConnectionsManager(this, ip);
            connectionsManager.StartServer();
        }

        public void UpdateConnectionStatus(bool connected)
        {
            /**
             * Update the connection status in statusStrip
             */
            this.InvokeIfRequired(() => { 
                serverStatusLabel.Text = connected ? "ONLINE" : "ČEKÁ SE NA PŘIPOJENÍ";
                serverStatusLabel.BackColor = connected ? Color.FromArgb(46, 204, 113) : Color.FromArgb(241, 196, 15);
            });
        }
    }
}
