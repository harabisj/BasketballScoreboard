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
    public partial class ShowResultsForm : Form
    {
        public ShowResultsForm()
        {
            InitializeComponent();
        }

        private void ShowResultsForm_Load(object sender, EventArgs e)
        {
            teamANameLabel.Text = Game.teamA.name;
            FillPlayersList(teamAPlayersList, Game.teamA);
            teamAScoreLabel.Text = Game.teamA.points.ToString();

            teamBNameLabel.Text = Game.teamB.name;
            FillPlayersList(teamBPlayersList, Game.teamB);
            teamBScoreLabel.Text = Game.teamB.points.ToString();
        }

        private void FillPlayersList(ListView playersList, Team team)
        {
            playersList.Items.Clear();
            foreach (Player player in team.players.OrderBy(player => player.id))
            {
                playersList.Items.Add(new ListViewItem(new string[] {
                    player.id.ToString(),
                    player.name,
                    player.fouls.ToString()
                }));
            }
        }
    }
}
