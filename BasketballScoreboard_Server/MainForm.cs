﻿using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasketballScoreboard_Server.Data;

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
                if (connected)
                {
                    serverStatusLabel.Text = "ČEKÁ SE NA PŘIPOJENÍ";
                    serverStatusLabel.BackColor = Color.FromArgb(241, 196, 15);
                }
                statusStrip.Visible = !connected;
                /* WIP serverStatusLabel.Text = connected ? "ONLINE" : "ČEKÁ SE NA PŘIPOJENÍ";
                serverStatusLabel.BackColor = connected ? Color.FromArgb(46, 204, 113) : Color.FromArgb(241, 196, 15);*/
            });
        }

        public void UpdateGameData(Game game)
        {
            this.InvokeIfRequired(() => {
                // Clock and period
                clockLabel.Text = TimeSpan.FromSeconds(game.currentTime).ToString(@"mm\:ss");
                currentPeriodLabel.Text = game.currentPeriod.ToString();

                // Team A
                teamANameLabel.Text = game.teamA.name;
                teamAPointsLabel.Text = game.teamA.points.ToString();
                teamAFoulsLabel.Text = game.teamA.GetTotalFouls().ToString();
                teamATimeoutsLeftLabel.Text = game.teamA.timeoutsLeft.ToString();

                // Team B
                teamBNameLabel.Text = game.teamB.name;
                teamBPointsLabel.Text = game.teamB.points.ToString();
                teamBFoulsLabel.Text = game.teamB.GetTotalFouls().ToString();
                teamBTimeoutsLeftLabel.Text = game.teamB.timeoutsLeft.ToString();
            });
        }
    }
}
