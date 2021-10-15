using System;
using System.Collections.Generic;
using System.Text;
using OO_Datastructuren.SLL;

namespace OO_Datastructuren.Stack
{
    class SLLStack
    {
        private List list = new List();
        
        public void Push(int value)
        {
            //for a SLL, it is best to add the element first in the list
            list.AddLast(value);
        }

        public int Pop()
        {
            if (!list.IsEmpty)
                return list.RemoveNode(list.Last);
            else
                throw new Exception("Stack is empty");
        }

        public int Peek()
        {
            return list.Last.Value;
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
