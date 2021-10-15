using MyLibrary.SLL.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Queue.SLL.Generic
{
    public class Queue<T> where T:IComparable<T>
    {
        private List<T> list = new List<T>();

        public void Enqueue(T value)
        {
            list.AddLast(value);
        }

        public T Dequeue()
        {
            if (!list.IsEmpty)
                return list.RemoveNode(list.First);
            else
                throw new Exception("Queue is empty");
        }

        public bool IsEmpty
        {
            get
            {
                return list.IsEmpty;
            }
        }

    }
}
