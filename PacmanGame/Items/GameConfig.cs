using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public enum Level { Easy, Medium, Hard, Advanced}
    public class GameConfig
    {
        public Level Level { get; set; }
        public int NumberOfEnemeies { get; set; }
        public int NumberOfPortals { get; set; }
    }
}
