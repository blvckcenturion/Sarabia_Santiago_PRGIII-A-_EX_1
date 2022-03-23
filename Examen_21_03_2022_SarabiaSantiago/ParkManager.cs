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

        public Park getPark(string parkName)
        {
            foreach (Park park in parks)
            {
                if (park.ParkName.ToLower() == parkName.ToLower()) return park;
            }
            return new Park("invalid");
        }

        public bool addPark(string parkName)
        {
            bool validPark = true;
            foreach (Park park in parks)
            {
                if (parkName.ToLower() == park.ParkName.ToLower())
                {
                    validPark = false;
                }
            }
            if (validPark) parks.Add(new Park(parkName));
            return validPark;
        }

        public bool addParkGame(string name, int maxCapacity, string parkName)
        {
            bool validGame = true;
            
            for(int i = 0; i < parks.Count; i++)
            {
                if (parks[i].ParkName == parkName) {
                    foreach(Game gm in parks[i].ParkGames)
                    {
                        if (gm.GameName == name) validGame = false;
                    }
                    if(validGame)
                    {
                        parks[i].ParkGames.Enqueue(new Game(name, maxCapacity));
                    }
                } 
            }
            return validGame;
        }

        public Game removeParkGame(string parkName)
        {
            Game gm = new Game("invalid", 0);

            for (int i = 0; i < parks.Count; i++)
            {
                if (parks[i].ParkName == parkName)
                {
                   gm = parks[i].ParkGames.Dequeue();
                }
            }
            return gm;
        }

        
    }
}
