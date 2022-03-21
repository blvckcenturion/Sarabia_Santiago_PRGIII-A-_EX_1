using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_21_03_2022_SarabiaSantiago
{
    public class Park
    {
        public string ParkName;
        public Queue<Game> ParkGames;

        public Park(string ParkName)
        {
            this.ParkName = ParkName;
            this.ParkGames = new Queue<Game>();
        }

        public Park(string ParkName, Queue<Game> ParkGames)
        {
            this.ParkName = ParkName;
            this.ParkGames = ParkGames;
        }
    }
}
