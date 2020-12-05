using SimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasketballScoreboard_Server.Data;
using Newtonsoft.Json;

namespace BasketballScoreboard_Server
{
    class ConnectionsManager
    {
        private MainForm mainForm;
        private SimpleTcpServer server;

        private string serverIp;
        private string clientIp = "";

        public ConnectionsManager(MainForm mainForm, string ip)
        {
            this.mainForm = mainForm;
            this.serverIp = ip;
            this.server = new SimpleTcpServer(serverIp, 23190);

            /**
             * Register event handlers
             */
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
            server.Events.DataReceived += DataReceived;
        }

        public void StartServer()
        {
            try
            {
                server.Start();
            }
            catch (Exception e)
            {
                DialogResult dr = MessageBox.Show(
                    e.Message,
                    "Při spouštění serveru nastala chyba",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error
                );

                if (dr == DialogResult.Retry)
                    StartServer();
                else
                    Environment.Exit(0);
            }
            mainForm.UpdateConnectionStatus(false);
        }

        /**
         * Event handlers
         */
        private void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            if (clientIp == "")
            {
                clientIp = Extensions.getIpOnly(e.IpPort);
                mainForm.UpdateConnectionStatus(true);
            }
        }

        private void ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            if (clientIp == Extensions.getIpOnly(e.IpPort))
            {
                clientIp = "";
                mainForm.UpdateConnectionStatus(false);
            }
        }

        private void DataReceived(object sender, DataReceivedFromClientEventArgs e)
        {
            if (clientIp == Extensions.getIpOnly(e.IpPort))
            {
                Game game = JsonConvert.DeserializeObject<Game>(Encoding.UTF8.GetString(e.Data));
                mainForm.UpdateGameData(game);
            }
        }
    }
}
