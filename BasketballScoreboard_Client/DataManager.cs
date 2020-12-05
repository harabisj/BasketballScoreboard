using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BasketballScoreboard_Client.Data;
using System.Windows.Forms;

namespace BasketballScoreboard_Client
{
    public class DataManager
    {
        private ConnectionsManager connectionsManager;

        public DataManager(ConnectionsManager connectionsManager)
        {
            this.connectionsManager = connectionsManager;
        }

        public string GetGameJson()
        {
            return JsonConvert.SerializeObject(new Game());
        }

        public void SendGameData()
        {
            connectionsManager.SendData(GetGameJson());
        }
    }
}
