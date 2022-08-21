using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Engine
{
    public abstract class Queue<T>
    {
        public Queue() { }

        public abstract void append(T item);

        public abstract void extend(IEnumerable<T> items);

        public abstract T pop();

        public abstract int size();

        public abstract bool contians(T item);
    }

}
