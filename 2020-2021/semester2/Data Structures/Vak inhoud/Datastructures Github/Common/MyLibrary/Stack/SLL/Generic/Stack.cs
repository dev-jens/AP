using MyLibrary.SLL.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Stack.SLL.Generic
{
    public class Stack<T> where T : IComparable<T>
    {
        private List<T> list = new List<T>();

        public void Push(T value)
        {
            //for a SLL, it is best to add the element first in the list
            list.AddFirst(value);
        }

        public T Pop()
        {
            if (!list.IsEmpty)
                return list.RemoveNode(list.First);
            else
                throw new Exception("Stack is empty");
        }

        public T Peek()
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
