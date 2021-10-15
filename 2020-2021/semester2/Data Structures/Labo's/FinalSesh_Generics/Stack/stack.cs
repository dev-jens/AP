using FinalSesh_Generics.SLL_Generic;
using System;
using System.Text;


namespace FinalSesh_Generics.Stack
{
    class stack<T> 
    {
        private SLL_Generic.List<T> list = new SLL_Generic.List<T>();

        public void Push(T value)
        {
            //for a SLL, it is best to add the element first in the list
            list.AddLast(value);
        }

        public T Pop()
        {
            if (!list.IsEmpty)
                return list.RemoveNode(list.Last);
            else
                throw new Exception("Stack is empty");
        }

        public T Peek()
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
