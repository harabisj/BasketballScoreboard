using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballScoreboard_Client.Data
{
    public class Game
    {
        public static bool started = false;

        [JsonProperty]
        public static Team teamA;

        [JsonProperty]
        public static Team teamB;

        [JsonProperty]
        public static int periodLength = 1;

        [JsonProperty]
        public static int currentPeriod = 1;
    }
}
