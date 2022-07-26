using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public class ObstacleCell : ICell
    {
       List<Direction> Connections { get; set; }
    }
}
