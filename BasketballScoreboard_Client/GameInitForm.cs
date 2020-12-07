using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;
using BasketballScoreboard_Client.Data;

namespace BasketballScoreboard_Client
{
    public partial class GameInitForm : Form
    {
        private ConnectionsManager connectionsManager;

        public GameInitForm(ConnectionsManager connectionsManager)
        {
            InitializeComponent();

            this.connectionsManager = connectionsManager;

            Game.teamA = new Team("První tým", 3);
            Game.teamB = new Team("Druhý tým", 3);
        }

        private void GameInitForm_Load(object sender, EventArgs e)
        {
            teamANameTextBox.Text = Game.teamA.name;
            teamBNameTextBox.Text = Game.teamB.name;
        }

        private void teamANameTextBox_TextChanged(object sender, EventArgs e)
        {
            Game.teamA.name = teamANameTextBox.Text;
        }

        private void teamBNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Game.teamB.name = teamBNameTextBox.Text;
        }

        private void teamAPlayersButton_Click(object sender, EventArgs e)
        {
            new EditTeamForm(Game.teamA).ShowDialog();
        }

        private void teamBPlayersButton_Click(object sender, EventArgs e)
        {
            new EditTeamForm(Game.teamB).ShowDialog();
        }

        private void createGameButton_Click(object sender, EventArgs e)
        {
            if (Game.teamA.players.Count > 0 && Game.teamB.players.Count > 0)
            {
                Game.started = true;
                Hide();
                new GameControlForm(connectionsManager).Show();
            }
            else
            {
                MessageBox.Show(
                    "Oba týmy musí mít alespoň jednoho hráče.",
                    "Nedostatečný počet hráčů",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void GameInitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Opravdu chcete ukončit BasketballScoreboard? Přijdete o veškerá zadaná data.",
                "Ukončit BasketballScoreboard",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                connectionsManager.Disconnect();
                Environment.Exit(0);
            }
            else
                e.Cancel = true;
        }

        private void periodLengthNumeric_ValueChanged(object sender, EventArgs e)
        {
            Game.periodLength = Convert.ToInt32(periodLengthNumeric.Value);
        }

        private void defaultTimeoutsNumeric_ValueChanged(object sender, EventArgs e)
        {
            Game.teamA.timeoutsLeft = Convert.ToInt32(defaultTimeoutsNumeric.Value);
            Game.teamB.timeoutsLeft = Convert.ToInt32(defaultTimeoutsNumeric.Value);
        }

        private void GameInitForm_Shown(object sender, EventArgs e)
        {
            if (Game.started)
            {
                Hide();
                Program.gameControlForm.Show();
            }
        }
    }
}
