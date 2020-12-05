using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BasketballScoreboard_Server.Data
{
    public class Player
    {
        [JsonProperty]
        public int id;

        [JsonProperty]
        public string name;

        [JsonProperty]
        public int fouls;
    }
}
