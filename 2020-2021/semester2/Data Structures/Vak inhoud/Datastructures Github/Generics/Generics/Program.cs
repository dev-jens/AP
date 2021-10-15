using MyLibrary;
using MyLibrary.Comparers;
using MyLibrary.SLL.Generic;
using MyLibrary.Sorteeralgoritmen.Generic;
using MyLibrary.Stack.Array.Generic;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ///Generic Stack
            var stack = new Stack<int>(20);
            stack.Push(10);
            stack.Push(12);
            stack.Push(5);

            int last = stack.Pop();
            //.....

            var stack2 = new Stack<double>(10);
            stack2.Push(10.34);
            stack2.Push(22.99);
            //...

            var stack3 = new Stack<Auto>(20);
            stack3.Push(new Auto());
            //...

            ///Generic SLL
            var SLL = new List<string>();
            SLL.AddFirst("Hallo");

            var node = SLL.FindNode("Hallo");
            SLL.AddAfter(node, "Beste");

            var bb = new BubbleSort();
            bb.Sort<string>(SLL);

            //Generic Insertion sort with specific Comparer
            var list = new Auto[3];
            list[0] = new Auto()
            {
                AantalKm = 1000
            };
            list[1] = new Auto()
            {
                AantalKm = 20
            };
            list[2] = new Auto()
            {
                AantalKm = 80
            };

            var isort = new InsertionSort();
            isort.Sort<Auto>(list, new CarComparerByKm());
            

        }
    }
}
