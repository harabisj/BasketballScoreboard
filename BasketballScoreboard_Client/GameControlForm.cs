using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasketballScoreboard_Client.Data;

namespace BasketballScoreboard_Client
{
    public partial class GameControlForm : Form
    {
        public GameControlForm()
        {
            InitializeComponent();
        }

        private void GameControlForm_Load(object sender, EventArgs e)
        {
            teamAGroupBox.Text = Game.teamA.name;
            teamBGroupBox.Text = Game.teamB.name;
            UpdateTeamGroupBoxes();
        }

        private void UpdateTeamGroupBoxes()
        {
            // Team A
            Team a = Game.teamA;
            teamAPointsLabel.Text = a.points.ToString();
            teamAFoulsLabel.Text = a.GetTotalFouls().ToString();
            teamATimeoutsLabel.Text = a.timeouts_left.ToString();

            // Team B
            Team b = Game.teamB;
            teamBPointsLabel.Text = b.points.ToString();
            teamBFoulsLabel.Text = b.GetTotalFouls().ToString();
            teamBTimeoutsLabel.Text = b.timeouts_left.ToString();
        }

        /**
         * Team A events
         */
        private void scoreASub1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.points != 0)
                Game.teamA.points--;
            UpdateTeamGroupBoxes();
        }

        private void scoreAAdd1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.points != 99)
                Game.teamA.points++;
            UpdateTeamGroupBoxes();
        }

        private void scoreAAdd2Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.points != 99)
                Game.teamA.points += 2;
            UpdateTeamGroupBoxes();
        }

        private void scoreAAdd3Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.points != 99)
                Game.teamA.points += 3;
            UpdateTeamGroupBoxes();
        }

        private void timeoutsASub1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.timeouts_left != 0)
                Game.teamA.timeouts_left--;
            UpdateTeamGroupBoxes();
        }

        private void timeoutsAAdd1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.timeouts_left != 99)
                Game.teamA.timeouts_left++;
            UpdateTeamGroupBoxes();
        }

        private void foulsASub1Button_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void foulsAAdd1Button_Click(object sender, EventArgs e)
        {
            // TODO
        }

        /**
         * Team B events
         */
        private void scoreBSub1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.points != 0)
                Game.teamB.points--;
            UpdateTeamGroupBoxes();
        }

        private void scoreBAdd1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.points != 99)
                Game.teamB.points++;
            UpdateTeamGroupBoxes();
        }

        private void scoreBAdd2Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.points != 99)
                Game.teamB.points += 2;
            UpdateTeamGroupBoxes();
        }

        private void scoreBAdd3Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.points != 99)
                Game.teamB.points += 3;
            UpdateTeamGroupBoxes();
        }

        private void timeoutsBSub1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.timeouts_left != 0)
                Game.teamB.timeouts_left--;
            UpdateTeamGroupBoxes();
        }

        private void timeoutsBAdd1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.timeouts_left != 0)
                Game.teamB.timeouts_left++;
            UpdateTeamGroupBoxes();
        }

        private void foulsBSub1Button_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void foulsBAdd1Button_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
