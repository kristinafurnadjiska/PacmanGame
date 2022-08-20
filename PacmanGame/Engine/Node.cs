using PacmanGame.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Engine
{
    public class Node
    {
        public Point State { get; set; }
        public Node Parent { get; set; }
        public Direction Action { get; set; }

        public Node(Point state) {
            State = state;
            Parent = null;
            Action = Direction.NONE;
        }

        public Node(Point state, Node parent, Direction direction)
        {
            State = state;
            Parent = parent;
            Action = direction;
        }

        public List<Node> expand(Problem problem)
        {
            List<Node> nodes = new List<Node>();

            List<Direction> actions = problem.actions(State);

            foreach(Direction action in actions)
            {
                nodes.Add(childNode(problem, action));
            }

            return nodes;
        }

        public Node childNode(Problem problem, Direction action)
        {
            ActionCell next = problem.result(State, action);
            return new Node(next.Position, this, action);
        }

        public List<Direction> solution()
        {
            List<Direction> result = new List<Direction>();
            Node current = this;
            while (current != null)
            {
                result.Add(current.Action);
                current = current.Parent;
            }

            return result;
        }

        public Direction getNextMove()
        {
            List<Direction> directions = solution();
            if (directions.Count < 2) return Direction.NONE;
            return directions[directions.Count - 2];
        }
    }
}
