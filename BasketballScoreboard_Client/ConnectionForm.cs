using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballScoreboard_Client
{
    public partial class ConnectionForm : Form
    {
        private ConnectionsManager connectionsManager;

        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {
            connectButton.Enabled = !(ipTextBox.Text == "");
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectionsManager = new ConnectionsManager(this, ipTextBox.Text);
            connectionsManager.TryToConnect();
        }
    }
}
