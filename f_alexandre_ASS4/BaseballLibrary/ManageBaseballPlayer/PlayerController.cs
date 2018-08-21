using BaseballLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBaseballPlayer
{
    class PlayerController
    {
        BaseballEntities dbContext = new BaseballEntities();

        private ObservableCollection<Player> _players = new ObservableCollection<Player>();
        public IEnumerable<Player> Players => _players;

        public PlayerController()
        {
            dbContext.Players.Load();
            QueryPlayers();
        }

        public void QueryPlayers(string lastName = null)
        {
            _players.Clear();
            IEnumerable<Player> queryPlayers;

            if (lastName != null && lastName.Length > 0)
            {
                queryPlayers = from player in dbContext.Players.Local
                       where player.LastName.ToLower().Contains(lastName.ToLower())
                       select player;
            }
            else
            {
                queryPlayers = dbContext.Players.Local;
            }

            foreach (var order in queryPlayers)
            {
                _players.Add(order);
            }
        }

        private int QueryCountPlayers()
        {
            return Players.Count();
        }

        public void QueryInsertPlayer (Player player)
        {
            if (player != null)
            {
                player.PlayerID = QueryCountPlayers();
                //This application does not have delete, if so this code needs to manage nextKey
                dbContext.Players.Local.Insert(player.PlayerID, player);
                dbContext.SaveChanges();
                QueryPlayers();
            }
        }

        public void QueryUpdatePlayer(Player player)
        {
            if (player != null && player.PlayerID != 0)
            {
                var result = Players.SingleOrDefault(plyer => plyer.PlayerID == player.PlayerID);
                if (result != null)
                {
                    result.FirstName = player.FirstName;
                    result.LastName = player.LastName;
                    result.BattingAverage = player.BattingAverage;
                    dbContext.SaveChanges();
                    QueryPlayers();
                }
            }
        }
    }
}
