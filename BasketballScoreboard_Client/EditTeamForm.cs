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
    public partial class EditTeamForm : Form
    {
        public Team team;

        public EditTeamForm(Team team)
        {
            InitializeComponent();

            this.team = team;
        }

        private void EditTeamForm_Load(object sender, EventArgs e)
        {
            teamNameLabel.Text = team.name;
            UpdatePlayersList();
        }

        private void UpdatePlayersList()
        {
            playersList.Items.Clear();
            foreach (Player player in team.players.OrderBy(player => player.id))
            {
                playersList.Items.Add(new ListViewItem(new string[] {
                    player.id.ToString(),
                    player.name,
                }));
            }
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            /**
             * Check for duplicate id
             */
            if (team.players.Select(player => player.id).Contains(Convert.ToInt32(playerIdNumeric.Value)))
            {
                MessageBox.Show(
                    "Zadané číslo hráče se v seznamu již vyskytuje. Zvolte jiné!" ,
                    "Neplatný vstup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            /**
             * Add the new player
             */
            team.players.Add(new Player(
                Convert.ToInt32(playerIdNumeric.Value),
                playerNameTextBox.Text
            ));
            UpdatePlayersList();

            playerIdNumeric.Value = playerIdNumeric.Value < 20 ? ++playerIdNumeric.Value : playerIdNumeric.Value;
            playerNameTextBox.Text = "";
            playerNameTextBox.Focus();
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            if (playersList.SelectedItems.Count != 1)
            {
                MessageBox.Show(
                    "Vyberte jednoho hráče k odstranění.",
                    "Neplatný požadavek",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            team.players.Remove(
                team.players.Find(
                    player => player.id.ToString() == playersList.SelectedItems[0].SubItems[0].Text
                )
            );
            UpdatePlayersList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
