using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballScoreboard_Client.Data
{
    public class Player
    {
        public int id;
        public string name;
        public int fouls;

        public Player(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.fouls = 0;
        }

        public Player(int id, string name, int fouls)
        {
            this.id = id;
            this.name = name;
            this.fouls = fouls;
        }
    }
}
