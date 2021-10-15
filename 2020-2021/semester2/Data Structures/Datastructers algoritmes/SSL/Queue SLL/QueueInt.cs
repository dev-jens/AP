using System;
using System.Collections.Generic;
using System.Text;

namespace SSL.Queue_SLL
{
    class QueueInt
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
