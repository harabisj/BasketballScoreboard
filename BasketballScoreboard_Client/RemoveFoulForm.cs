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
    public partial class RemoveFoulForm : Form
    {
        private Team team;

        public RemoveFoulForm(Team team)
        {
            InitializeComponent();

            this.team = team;

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

        private void removeFoulButton_Click(object sender, EventArgs e)
        {
            if (playersList.SelectedItems.Count != 1)
            {
                MessageBox.Show(
                    "Vyberte jednoho hráče k přidání foulu.",
                    "Neplatný požadavek",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Player player = team.players.Find(p => p.id.ToString() == playersList.SelectedItems[0].SubItems[0].Text);
            if (player.fouls == 0)
            {
                MessageBox.Show(
                    "Počet foulů nesmí být záporný.",
                    "Neplatný požadavek",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            player.fouls--;
            Close();
        }
    }
}
