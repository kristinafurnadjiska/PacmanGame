using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public class Portal
    {
        public Direction Direction { get; set; }

        public GameCell Destination { get; set; }
    }
}
