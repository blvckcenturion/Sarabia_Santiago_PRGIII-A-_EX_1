﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_21_03_2022_SarabiaSantiago
{
    public class Game
    {
        string GameName { get; set; }
        int MaxCapacity { get; set; }

        public Game(string GameName, int MaxCapacity)
        {
            this.GameName = GameName;
            this.MaxCapacity = MaxCapacity;
        }
    }
}
