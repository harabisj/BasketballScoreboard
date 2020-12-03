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
        }
    }
}
