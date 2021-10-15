using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Stack.Array.Generic
{
    public class Stack<T>
    {
        private T[] stackArray;
        private int top = -1;

        public Stack(int InitialSize = 5)
        {
            stackArray = new T[InitialSize];
        }

        public void Push(T item)
        {
            if (IsFull)
            {
                var newArray = new T[stackArray.Length * 2];
                System.Array.Copy(stackArray, newArray, stackArray.Length);
                stackArray = newArray;
            }

            stackArray[++top] = item;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new Exception("The stack is empty. Pop is not allowed");

            return stackArray[top--];
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new Exception("The stack is empty. Peek is not allowed");

            return stackArray[top];
        }

        public bool IsEmpty
        {
            get
            {
                return top == -1;
            }
        }

        public bool IsFull
        {
            get
            {
                return top == stackArray.Length - 1;
            }
        }

        public T[] Items
        {
            get
            {
                T[] temp = new T[top + 1];
                if (!IsEmpty)
                    System.Array.Copy(stackArray, temp, top + 1);
                return temp;
            }
        }
    }
}
