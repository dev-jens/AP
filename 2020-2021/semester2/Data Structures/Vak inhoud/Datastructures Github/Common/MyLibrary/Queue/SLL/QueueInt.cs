using MyLibrary.SLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Queue.SLL
{
    public class QueueInt
    {
        private ListInt list = new ListInt();

        public void Enqueue(int value)
        {
            list.AddLast(value);
        }

        public int Dequeue()
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
