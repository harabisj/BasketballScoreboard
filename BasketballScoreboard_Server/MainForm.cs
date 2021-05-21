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
using BasketballScoreboard_Server.Data;
using System.Media;
using System.Threading;
using System.IO;

namespace BasketballScoreboard_Server
{
    public partial class MainForm : Form
    {
        private ConnectionsManager connectionsManager;
        private SoundPlayer soundPlayer;
        private int oldClock = -1;

        public MainForm(string ip)
        {
            InitializeComponent();

            /**
             * Create ConnectionsManager instance and start the server
             */
            connectionsManager = new ConnectionsManager(this, ip);
            connectionsManager.StartServer();

            soundPlayer = new SoundPlayer(Properties.Resources.buzzer);
            soundPlayer.LoadAsync();
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
            });
        }

        public void UpdateGameData(Game game)
        {
            this.InvokeIfRequired(() => {
                if (game.isBuzzing) soundPlayer.Play();
                else soundPlayer.Stop();

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
