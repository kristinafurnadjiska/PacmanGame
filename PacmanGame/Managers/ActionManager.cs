using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Items;

namespace PacmanGame.Managers
{
    public class ActionManager
    {
        public void Initialize(ICell[,] Cells, List<Point> Obstacles)
        {
            for (int i = 0; i < Constants.HEIGHT_SIZE; i++)
            {
                for (int j = 0; j < Constants.WIDTH_SIZE; j++)
                {
                    Point p = new Point(i, j);
                    if (!Obstacles.Contains(p))
                    {
                        Cells[i, j] = new ActionCell(p, false, getActionPointDirections(p, Obstacles), false);
                    }
                }
            }
        }

        private List<Direction> getActionPointDirections(Point point, List<Point> points)
        {
            List<Direction> directions = new List<Direction>();
            Point up = new Point(point.X - 1, point.Y);
            Point down = new Point(point.X + 1, point.Y);
            Point left = new Point(point.X, point.Y - 1);
            Point right = new Point(point.X, point.Y + 1);

            if (!points.Contains(up) && ValidRange(up.X, 0, Constants.HEIGHT_SIZE))
            {
                directions.Add(Direction.UP);
            }
            if (!points.Contains(down) && ValidRange(down.X, 0, Constants.HEIGHT_SIZE))
            {
                directions.Add(Direction.DOWN);
            }
            if (!points.Contains(left) && ValidRange(left.Y, 0, Constants.WIDTH_SIZE))
            {
                directions.Add(Direction.LEFT);
            }
            if (!points.Contains(right) && ValidRange(right.Y, 0, Constants.WIDTH_SIZE))
            {
                directions.Add(Direction.RIGHT);
            }

            return directions;
        }

        private Boolean ValidRange(int value, int min, int max)
        {
            return value >= min && value < max;
        }

        public Point UpdatePosition(Point current, Direction direction)
        {
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
