using System;
using System.Collections.Generic;

namespace SortedList_.net
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorted = new SortedSet<int>();
            sorted.Add(5);
            sorted.Add(25);
            sorted.Add(54);
            sorted.Add(1);
            sorted.Add(2);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            LinkedList<int> LL = new LinkedList<int>();
            LL.AddFirst(5);

            Queue<int> q = new Queue<int>();

            Stack<int> stk = new Stack<int>();


            var Dict = new Dictionary<int, string>();
            Dict.Add(1, "first num");
            foreach (var item in Dict)
            {
                Console.WriteLine($"key = " + item.Key + "value = " + item.Value);
            }

            SortedDictionary<int, string> SDict = new SortedDictionary<int, string>();
            SDict.Add(2, "Zecond num");
            SDict.Add(1, "Wecond num");
            SDict.Add(3, "Aecond num");

            foreach (var item in SDict)
            {
                Console.WriteLine($"key = " + item.Key + " value = " + item.Value);
            }
            foreach (var item in SDict)
            {
                Console.WriteLine($"value = " + item.Value + " key = " + item.Key);
            }

        }
    }
}
