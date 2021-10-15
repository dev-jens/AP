using SSL.Stack_SLL;
using System;

namespace SSL
{
    class Program
    {
        static void Main(string[] args)
        {
            StackInt arr = new StackInt();
            arr.Push(5);

            Console.WriteLine(arr.Peek());
        }
    }
}
