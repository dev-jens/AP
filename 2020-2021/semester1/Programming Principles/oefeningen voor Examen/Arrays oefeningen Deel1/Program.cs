using System;

namespace Arrays_oefeningen_Deel1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LEN = 10;
            int[] lst = new int[LEN];

            Console.WriteLine("geeft 10 getallen: ");
            for (int i = 0; i < lst.Length; i++)
            {
                Console.Write($"getal{i}: ");
                int input = int.Parse(Console.ReadLine());
                lst[i] = input;
            }

            Console.WriteLine("*********");
            Console.WriteLine("welke getal moet verwijdert worden");
            int del = int.Parse(Console.ReadLine());
            int indexx = Array.IndexOf(lst, del);
            int index = -1
                for (int i = 0; i < index; i++)
                {
                    Console.Write($"{lst[i]},");
                }
                for (int i = index+1; i < lst.Length; i++)
                {
                    Console.Write($"{lst[i]},");
                }
                if (index != -1)
                {
                    Console.Write($"{-1}");
                }
            }
        }
    }
}
