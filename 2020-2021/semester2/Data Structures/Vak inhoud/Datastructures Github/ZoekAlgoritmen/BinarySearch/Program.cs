using MyLibrary.Sorteeralgoritmen;
using System;
using MyLibrary.ZoekAlgoritmen;
using MyLibrary.DLL;
using MyLibrary;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] list = new RandomGenerator(100, 0, 200, true).GenerateNumbers();
            QuickSort qs = new QuickSort();
            qs.Sort(list);

            var bs = new MyLibrary.ZoekAlgoritmen.BinarySearch();

            Console.WriteLine("value 22: " + (bs.Find(list, 22) != -1 ? "found" : "not found"));
            Console.WriteLine("value 23: " + (bs.Find(list, 23) != -1 ? "found" : "not found"));
            Console.WriteLine("value 24: " + (bs.Find(list, 24) != -1 ? "found" : "not found"));
            Console.WriteLine("value 25: " + (bs.Find(list, 25) != -1 ? "found" : "not found"));
            Console.WriteLine("value 26: " + (bs.Find(list, 26) != -1 ? "found" : "not found"));
            Console.WriteLine("value 27: " + (bs.Find(list, 27) != -1 ? "found" : "not found"));
            Console.WriteLine("value 28: " + (bs.Find(list, 28) != -1 ? "found" : "not found"));
            Console.WriteLine("value 29: " + (bs.Find(list, 29) != -1 ? "found" : "not found"));
        }
    }
}
