using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballScoreboard_Server.Data
{
    public class Game
    {
        [JsonProperty]
        public Team teamA { get; set; }

        [JsonProperty]
        public Team teamB { get; set; }

        [JsonProperty]
        public int periodLength { get; set; }

        [JsonProperty]
        public int currentPeriod { get; set; }


        [JsonProperty]
        public int currentTime { get; set; }

        [JsonProperty]
        public bool isBuzzing { get; set; }
    }
}
