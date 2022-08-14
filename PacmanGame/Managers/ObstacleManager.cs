using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Items;

namespace PacmanGame.Managers
{
    public class ObstacleManager
    {
        public List<Point> Obstacles { get; set; }

        public ObstacleManager()
        {
            Obstacles = new List<Point>();
        }

        public void Initialize(ICell [,] Cells)
        {
            List<Point> points = readObstaclesFromFile();

            foreach (Point point in points)
            {
                Cells[point.X, point.Y] = new ObstacleCell(point, getObsticlePointDirections(point, points));
            }

            Obstacles = points;

        }

        public List<Direction> getObsticlePointDirections(Point point, List<Point> points)
        {
            List<Direction> directions = new List<Direction>();
            Point up = new Point(point.X - 1, point.Y);
            Point down = new Point(point.X + 1, point.Y);
            Point left = new Point(point.X, point.Y - 1);
            Point right = new Point(point.X, point.Y + 1);

            if (points.Contains(up))
            {
                directions.Add(Direction.UP);
            }
            if (points.Contains(down))
            {
                directions.Add(Direction.DOWN);
            }
            if (points.Contains(left))
            {
                directions.Add(Direction.LEFT);
            }
            if (points.Contains(right))
            {
                directions.Add(Direction.RIGHT);
            }

            return directions;
        }

        public List<Point> readObstaclesFromFile()
        {
            List<Point> points = new List<Point>();
            string path = @"Files\medium.csv";

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    String[] parts = line.Split(',');
                    int x = Int16.Parse(parts[0]);
                    int y = Int16.Parse(parts[1]);

                    points.Add(new Point(x, y));

                }
            }

            return points;
        }

    }
}
