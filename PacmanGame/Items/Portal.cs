using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public class Portal
    {
        public Direction Direction { get; set; }
        public Point Destination { get; set; }

        public Portal(Point destination, Direction direction)
        {
            Direction = direction;
            Destination = destination;
        }


    }

}
