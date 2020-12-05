using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BasketballScoreboard_Server.Data
{
    public class Team
    {
        [JsonProperty]
        public string name;

        [JsonProperty]
        public List<Player> players;

        [JsonProperty]
        public int points;

        [JsonProperty]
        public int timeoutsLeft;

        public int GetTotalFouls()
        {
            return players.Select(player => player.fouls).Sum();
        }
    }
}
