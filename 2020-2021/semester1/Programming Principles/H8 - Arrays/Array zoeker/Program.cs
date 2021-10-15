using System;

namespace Array_zoeker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lijst = { 2, 3, 4, 5, 6, 8, 10, 15, 16, 19 };

            Console.WriteLine("welke getal moet er uit ?");
            int del = int.Parse(Console.ReadLine());
            int index = -1; // Array.IndexOf(lijst, del);
            bool found = false;

            for (int i = 0; i < lijst.Length; i++)
            {
                if (!found && lijst[i] == del)
                {
                    index = i;
                    found = true;
                }
            }

            if (found)
            {
                for (int i = 0; i < index; i++)
                {
                    Console.Write($"{lijst[i]} ");
                }
                for (int i = index +1 ; i < lijst.Length; i++)
                {
                    Console.Write($"{lijst[i]} ");
                }

                if (index != -1)
                {
                    Console.Write($" {-1}");
                }
            }
        }      
    }
}
