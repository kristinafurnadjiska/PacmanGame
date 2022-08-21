using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Engine
{
    public class Search
    {
        public static Node graphSearch(Problem problem, Queue<Node> queue)
        {
            HashSet<Point> visited = new HashSet<Point>();

            queue.append(new Node(problem.Initial));
            while (queue.size() > 0)
            {
                Node node = queue.pop();
                if (problem.isFinsished(node.State))
                {
                    return node;
                }
                else
                {
                    List<Node> next = node.expand(problem);
                    foreach (Node nextNode in next)
                    {
                        if (!visited.Contains(nextNode.State))
                        {
                            queue.append(nextNode);
                        }
                    }
                    visited.Add(node.State);
                }
            }

            return null;
        }

        public static Node breadthFirstSerach(Problem problem)
        {
            return graphSearch(problem, new FIFOQueue<Node>());
        }
    }
}
