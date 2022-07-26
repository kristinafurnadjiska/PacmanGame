using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public class Game
    {
        public string Logo { get; set; }
        public string Name { get; set; }
        public GameConfig Config { get; set; }
        public GameScore Score { get; set; }
    }
}
