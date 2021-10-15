using MyLibrary.ZoekAlgoritmen;
using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, give me some texts to add to the hash table!");

            string input = "";
            var ht = new Hashtable_v3(20);

            while (input != "exit")
            {
                input = Console.ReadLine();
                try
                {
                    ht.AddItem(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();
                Console.WriteLine("array contains:");
                var a = ht.Array;
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine($"{i}: {(a[i] == null ? "empty": a[i])}");
                }
                Console.WriteLine();
            }
        }
    }
}
