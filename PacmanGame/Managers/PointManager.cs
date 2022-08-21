using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Managers
{
    public class PointManager
    {

        public static Point ConvertPoint(Point point, Direction direction)
        {
            Point current = new Point(point.X, point.Y);

            if (direction == Direction.UP)
            {
                current.X -= 1;
            }
            if (direction == Direction.DOWN)
            {
                current.X += 1;
            }
            if (direction == Direction.RIGHT)
            {
                current.Y += 1;
            }
            if (direction == Direction.LEFT)
            {
                current.Y -= 1;
            }

            return current;
        }
    }
}
