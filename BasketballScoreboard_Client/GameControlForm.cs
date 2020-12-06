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
        private ConnectionsManager connectionsManager;

        private TimerManager mainClock;
        private TimerManager timeoutClock;

        private readonly Control[] mainFreezeControls;
        private readonly Control[] timeoutFreezeControls;

        public GameControlForm(ConnectionsManager connectionsManager)
        {
            InitializeComponent();

            this.connectionsManager = connectionsManager;

            timeoutClock = new TimerManager(
                timeoutTimer,
                30,
                OnTimeoutClockUpdate,
                OnTimeoutClockStop
            );
            mainClock = new TimerManager(
                mainTimer,
                Game.periodLength * 60,
                OnMainClockUpdate,
                OnMainClockStop
            );

            mainFreezeControls = new Control[] {
                clockStartButton,
                clockStopButton,
                periodAdd1Button,
                periodSub1Button,
                runTimeoutButton
            };
            timeoutFreezeControls = mainFreezeControls.Union(new Control[] {
                scoreASub1Button,
                scoreAAdd1Button,
                scoreAAdd2Button,
                scoreAAdd3Button,
                foulsASub1Button,
                foulsAAdd1Button,
                timeoutsASub1Button,
                timeoutsAAdd1Button,

                scoreBSub1Button,
                scoreBAdd1Button,
                scoreBAdd2Button,
                scoreBAdd3Button,
                foulsBSub1Button,
                foulsBAdd1Button,
                timeoutsBSub1Button,
                timeoutsBAdd1Button,
            }).ToArray();
        }

        private void GameControlForm_Load(object sender, EventArgs e)
        {
            teamAGroupBox.Text = Game.teamA.name;
            teamBGroupBox.Text = Game.teamB.name;
            UpdateTeamGroupBoxes();
            UpdatePeriod();
            SendGameData();
        }

        /**
         * Form update methods
         */
        private void UpdateTeamGroupBoxes()
        {
            // Team A
            Team a = Game.teamA;
            teamAPointsLabel.Text = a.points.ToString();
            teamAFoulsLabel.Text = a.GetTotalFouls().ToString();
            teamATimeoutsLabel.Text = a.timeoutsLeft.ToString();

            // Team B
            Team b = Game.teamB;
            teamBPointsLabel.Text = b.points.ToString();
            teamBFoulsLabel.Text = b.GetTotalFouls().ToString();
            teamBTimeoutsLabel.Text = b.timeoutsLeft.ToString();
        }

        private void UpdatePeriod()
        {
            periodNumberLabel.Text = Game.currentPeriod.ToString();
        }

        /**
         * ConnectionsManager.SendGameData() alias
         */
        private void SendGameData()
        {
            connectionsManager.SendGameData();
        }


        /**
         * Team A events
         */
        private void scoreASub1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.points != 0)
                Game.teamA.points--;
            UpdateTeamGroupBoxes();
            SendGameData();
        }

        private void scoreAAdd1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.points != 99)
                Game.teamA.points++;
            UpdateTeamGroupBoxes();
            SendGameData();
        }

        private void scoreAAdd2Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.points != 99)
                Game.teamA.points += 2;
            UpdateTeamGroupBoxes();
            SendGameData();
        }

        private void scoreAAdd3Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.points != 99)
                Game.teamA.points += 3;
            UpdateTeamGroupBoxes();
            SendGameData();
        }

        private void timeoutsASub1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.timeoutsLeft != 0)
                Game.teamA.timeoutsLeft--;
            UpdateTeamGroupBoxes();
            SendGameData();
        }

        private void timeoutsAAdd1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamA.timeoutsLeft != 99)
                Game.teamA.timeoutsLeft++;
            UpdateTeamGroupBoxes();
            SendGameData();
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
            SendGameData();
        }

        private void scoreBAdd1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.points != 99)
                Game.teamB.points++;
            UpdateTeamGroupBoxes();
            SendGameData();
        }

        private void scoreBAdd2Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.points != 99)
                Game.teamB.points += 2;
            UpdateTeamGroupBoxes();
            SendGameData();
        }

        private void scoreBAdd3Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.points != 99)
                Game.teamB.points += 3;
            UpdateTeamGroupBoxes();
            SendGameData();
        }

        private void timeoutsBSub1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.timeoutsLeft != 0)
                Game.teamB.timeoutsLeft--;
            UpdateTeamGroupBoxes();
            SendGameData();
        }

        private void timeoutsBAdd1Button_Click(object sender, EventArgs e)
        {
            if (Game.teamB.timeoutsLeft != 0)
                Game.teamB.timeoutsLeft++;
            UpdateTeamGroupBoxes();
            SendGameData();
        }

        private void foulsBSub1Button_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void foulsBAdd1Button_Click(object sender, EventArgs e)
        {
            // TODO
        }


        /**
         * Other events
         */
        private void clockStartButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Black;
            mainClock.Start();
        }

        private void clockStopButton_Click(object sender, EventArgs e)
        {
            mainClock.Stop();
        }

        public bool OnMainClockUpdate(int currentSeconds)
        {
            Game.currentTime = currentSeconds;
            SendGameData();
            this.InvokeIfRequired(() => {
                clockLabel.Text = TimeSpan.FromSeconds(currentSeconds).ToString(@"mm\:ss");
            });
            return true;
        }

        public void OnMainClockStop()
        {
            this.InvokeIfRequired(async () => {
                clockLabel.ForeColor = Color.Red;

                if (Game.currentPeriod != 4)
                {
                    Extensions.ControlsEnabled(mainFreezeControls, false);
                    
                    await Task.Delay(8000);

                    Extensions.ControlsEnabled(mainFreezeControls, true);
                    Game.currentPeriod++;
                    UpdatePeriod();
                    mainClock.Reset();
                    clockLabel.ForeColor = Color.Black;
                }
            });
        }

        public bool OnTimeoutClockUpdate(int currentSeconds)
        {
            Game.currentTime = currentSeconds;
            SendGameData();
            this.InvokeIfRequired(() => {
                clockLabel.Text = TimeSpan.FromSeconds(currentSeconds).ToString(@"mm\:ss");
            });
            return true;
        }
        
        public void OnTimeoutClockStop()
        {
            Extensions.ControlsEnabled(timeoutFreezeControls, true);
            this.InvokeIfRequired(async () => {
                clockLabel.ForeColor = Color.Green;
                await Task.Delay(8000);
                clockLabel.ForeColor = Color.Black;
            });
        }



        private void periodSub1Button_Click(object sender, EventArgs e)
        {
            if (Game.currentPeriod != 1)
                Game.currentPeriod--;
            mainClock.Reset();
            UpdatePeriod();
            SendGameData();
        }

        private void periodAdd1Button_Click(object sender, EventArgs e)
        {
            if (Game.currentPeriod != 4)
                Game.currentPeriod++;
            mainClock.Reset();
            UpdatePeriod();
            SendGameData();
        }

        private void runTimeoutButton_Click(object sender, EventArgs e)
        {
            mainClock.Stop();
            clockLabel.ForeColor = Color.Black;
            timeoutClock.Reset();
            timeoutClock.Start();

            Extensions.ControlsEnabled(timeoutFreezeControls, false);
        }
    }
}
