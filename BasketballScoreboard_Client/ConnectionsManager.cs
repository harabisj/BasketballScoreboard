﻿using SimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballScoreboard_Client
{
    public class ConnectionsManager
    {
        private SimpleTcpClient client;
        private ConnectionForm connectionForm;
        private MainForm mainForm;

        private string ip;

        public ConnectionsManager(ConnectionForm connectionForm, string ip)
        {
            this.connectionForm = connectionForm;
            this.ip = ip;

            this.mainForm = new MainForm(this);
        }

        public void TryToConnect()
        {
            try
            {
                client = new SimpleTcpClient(ip, 23190);

                /**
                 * Register event handlers
                 */
                client.Events.Connected += Connected;
                client.Events.Disconnected += Disconnected;
                client.Events.DataReceived += DataReceived;

                client.Connect();
            }
            catch (Exception e)
            {
                DialogResult dr = MessageBox.Show(
                    e.Message,
                    "Nastala chyba při pokusu o připojení",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error
                );

                if (dr == DialogResult.Retry)
                    TryToConnect();
            }
        }

        public void SendData(string data)
        {
            client.Send(data);
        }

        /**
         * Event handlers
         */
        public void Connected(object sender, EventArgs e)
        {
            connectionForm.Hide();
            mainForm.Show();
        }

        public void Disconnected(object sender, EventArgs e)
        {
            mainForm.BeginInvoke((MethodInvoker) delegate { mainForm.Hide(); });
            connectionForm.BeginInvoke((MethodInvoker) delegate { connectionForm.Show(); });
        }

        public void DataReceived(object sender, DataReceivedFromServerEventArgs e)
        {
            MessageBox.Show(Encoding.UTF8.GetString(e.Data), "client");
        }
    }
}