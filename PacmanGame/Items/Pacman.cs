using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public class Pacman
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public Point Position { get; set; }
        public Direction Direction { get; set; }    
    }
}
