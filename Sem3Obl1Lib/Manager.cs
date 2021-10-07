using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3Obl1Lib
{
    public class Manager : IManager
    {
        private static readonly List<FootballPlayer> players = new List<FootballPlayer>
        {
            new FootballPlayer(1, "Kenneth", 240, 33),
            new FootballPlayer(2, "Andrea", 50, 45),
            new FootballPlayer(3, "Annett", 120, 73),
            new FootballPlayer(4, "Michael", 68, 05),
        };

        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(players);
        }

        public FootballPlayer Get(int id)
        {
            return players.Find(i => i.Id == id);
        }

        public bool Create(FootballPlayer value)
        {
            players.Add(value);
            return true;
        }

        public bool Update(int id, FootballPlayer value)
        {
            FootballPlayer player = Get(id);
            if (player != null)
            {
                player.Id = value.Id;
                player.Name = value.Name;
                player.Price = value.Price;
                player.ShirtNumber = value.ShirtNumber;

                return true;
            }
            return false;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer player = Get(id);
            players.Remove(player);
            return player;
        }
    }
}
