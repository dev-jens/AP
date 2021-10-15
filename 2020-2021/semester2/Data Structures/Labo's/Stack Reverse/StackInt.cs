using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Reverse
{
    class StackInt
    {

        public int top { get; set; } = -1;
        int[] stack = new int[10];

        public void Push(int getal)
        {
            if (IsFull())
            {
                int[] temp = new int[stack.Length * 2];
                for (int i = 0; i < stack.Length; i++)
                {
                    temp[i] = stack[i];
                }
                stack = temp;
            }

            top++;
            stack[top] = getal;
        }

        public int pop()
        {
            if (IsEmpty())
            {
                return -99999;
            }
            int value = stack[top];
            top--;
            return value;
        }


        public bool IsFull()
        {
            return top == stack.Length - 1;
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}
