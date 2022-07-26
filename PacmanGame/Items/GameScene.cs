using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public class GameScene
    {
        public List<ObstacleCell> obstacles;
        public GameCell [][] Matrix { get; set; }
        public HashSet<ActionCell> Awards { get; set; }

        public List<Enemy> Enemies { get; set; }

        public List<Pacman> Pacmen { get; set; }

        public GameConfig Config { get; set; }



    }
}
