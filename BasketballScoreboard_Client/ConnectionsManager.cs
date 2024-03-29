﻿using SimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasketballScoreboard_Client.Data;
using Newtonsoft.Json;

namespace BasketballScoreboard_Client
{
    public class ConnectionsManager
    {
        private SimpleTcpClient client;
        private ConnectionForm connectionForm;
        private GameInitForm gameInitForm;

        private string ip;

        public ConnectionsManager(ConnectionForm connectionForm, string ip)
        {
            this.connectionForm = connectionForm;
            this.ip = ip;

            this.gameInitForm = new GameInitForm(this);
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

        public void Disconnect()
        {
            client.Disconnect();
        }

        /**
         * Event handlers
         */
        public void Connected(object sender, EventArgs e)
        {
            connectionForm.InvokeIfRequired(() =>
            {
                connectionForm.Hide();
            });

            if (Game.started)
                Program.gameControlForm.InvokeIfRequired(() => { 
                    Program.gameControlForm.Show();
                });
            else
                gameInitForm.InvokeIfRequired(() => {
                    gameInitForm.Show();
                });


        }

        public void Disconnected(object sender, EventArgs e)
        {
            if (Game.started)
                Program.gameControlForm.StopAllClocks();

            DialogResult dr = MessageBox.Show(
                "Spojení se serverem bylo přeruešno... Opakovat pokus o připojení?",
                "Chyba spojení",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Retry)
                TryToConnect();
        }

        public void DataReceived(object sender, DataReceivedFromServerEventArgs e)
        {
            // WIP
            MessageBox.Show(Encoding.UTF8.GetString(e.Data), "client");
        }

        /**
         * Data manipulation
         */
        public void SendGameData()
        {
            /**
             * Serialize the game data and send to the server
             */
            try
            {
                client.Send(JsonConvert.SerializeObject(new Game()));
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Data se ńepodařilo odeslat: " + e.Message,
                    "Chyba spojení",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
