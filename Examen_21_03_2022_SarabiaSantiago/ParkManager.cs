using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Examen_21_03_2022_SarabiaSantiago
{
    public class ParkManager
    {
        // Must change path
        
         List<Park> parks = new List<Park>();
        public List<Park> getParks()
        {
            return parks;
        }

        public List<Park> addPark(string parkName)
        {
            parks.Add(new Park(parkName));
            return parks;
        }

        public void addParkGame(string name, int maxCapacity, string parkName)
        {
            for (int i = 0; i < parks.Count; i++)
            {
                if (parks[i].ParkName == parkName) parks[i].ParkGames.Enqueue(new Game(name, maxCapacity));
            }
        }

        
    }
}
