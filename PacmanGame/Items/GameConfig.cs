﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    //public enum Level { Easy, Medium, Hard}
    public class GameConfig
    {
        public string Level { get; set; }
        public int NumberOfEnemeies { get; set; }
        public int NumberOfPortals { get; set; }

        public GameConfig(string level, int numberOfEnemeies, int numberOfPortals)
        {
            Level = level;
            NumberOfEnemeies = numberOfEnemeies;
            NumberOfPortals = numberOfPortals;
        }
    }
}
