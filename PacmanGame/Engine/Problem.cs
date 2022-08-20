using PacmanGame.Items;
using PacmanGame.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Engine
{
    public class Problem
    {
        public Point Initial { get; set; }
        public Point Goal { get; set; }

        public ICell [,] Matrix { get; set; }

        public Problem(ICell [,] matrix, Point initial, Point goal)
        {
            Initial = initial;
            Goal = goal;
            Matrix = matrix;
        }

        public Dictionary<Direction, Point> successors(Point position)
        {
            ActionCell state = Matrix[position.X, position.Y] as ActionCell;
            List<Direction> directions = state.Actions;
            Point point = state.Position;
            Dictionary<Direction, Point> result = new Dictionary<Direction, Point>();
            foreach (Direction direction in directions)
            {
                result.Add(direction, PointManager.ConvertPoint(point, direction));
            }
            return result;
        }

        public List<Direction> actions(Point position)
        {
            ActionCell state = Matrix[position.X, position.Y] as ActionCell;
            return state.Actions;
        }

        public ActionCell result(Point point, Direction action)
        {
            Point state = successors(point)[action];
            return Matrix[state.X, state.Y] as ActionCell;
        }

        public bool isFinsished(Point state) { return state.Equals(Goal); }
    }
}
