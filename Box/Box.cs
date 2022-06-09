using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list = new List<T>();

        public int Count => list.Count;

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            T removedElement = this.list[this.Count - 1];
            list.RemoveAt(this.Count - 1);

            return removedElement;
        }
    }
}
