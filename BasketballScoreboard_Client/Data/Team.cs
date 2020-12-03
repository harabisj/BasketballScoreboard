using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballScoreboard_Client.Data
{
    public class Team
    {
        public string name;
        public List<Player> players;
        public int points;
        public int timeouts_left;

        public Team(string name, List<Player> players, int points, int timeouts_left)
        {
            this.name = name;
            this.players = players;
            this.points = points;
            this.timeouts_left = timeouts_left;
        }

        public Team(string name, List<Player> players, int timeouts_left)
        {
            this.name = name;
            this.players = players;
            this.points = 0;
            this.timeouts_left = timeouts_left;
        }

        public Team(string name, int timeouts_left)
        {
            this.name = name;
            this.players = new List<Player>();
            this.points = 0;
            this.timeouts_left = timeouts_left;
        }

        public int GetTotalFouls()
        {
            return players.Select(player => player.fouls).Sum();
        }
    }
}
