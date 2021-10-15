using System;
using System.Collections.Generic;
using System.Text;

namespace SSL.Stack_SLL
{
    class StackInt
    {
        private ListInt list = new ListInt();

        public void Push(int value)
        {
            //for a SLL, it is best to add the element first in the list
            list.AddFirst(value);
        }

        public int Pop()
        {
            if (!list.IsEmpty)
                return list.RemoveNode(list.First);
            else
                throw new Exception("Stack is empty");
        }

        public int Peek()
        {
            return list.First.Value;
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
