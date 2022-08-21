using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Engine
{
    public class FIFOQueue<T>: Queue<T>
    {
        private List<T> queue;

        public FIFOQueue()
        {
            queue = new List<T>();
        }

        public override void append(T item)
        {
            queue.Add(item);
        }

        public override void extend(IEnumerable<T> items)
        {
            queue.AddRange(items);
        }

        public override T pop()
        {
            T item = queue[0];
            queue.RemoveAt(0);
            return item;
        }

        public override int size()
        {
            return queue.Count;
        }

        public override bool contians(T item)
        {
            return queue.Contains(item);
        }

    }
}
