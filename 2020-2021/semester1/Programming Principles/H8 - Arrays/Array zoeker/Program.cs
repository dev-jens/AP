using System;

namespace Array_zoeker
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] lijst = {2,3,4,5,6,8,10,15,16,19};
            int[] lijst = leesGetallen(10);
            
            for (int i = 0; i < lijst.Length; i++)
            {
                Console.Write($"{lijst[i]} ");
            }
            Console.Write("\n");

            Console.WriteLine("welk getal moet verwijdert worden");
            int input = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(lijst, input);

            for (int i = 0; i < index; i++)
            {
                Console.Write($"{lijst[i]} "); 
            }
            for (int i = index + 1; i < lijst.Length; i++)
            {
                Console.Write($"{lijst[i]} "); 
            }

            if (index != -1)
            {
                Console.Write($"{-1}");
            }
           

        }
        static int[] leesGetallen(int max)
        {
            int[] lijst = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("Geef een nummer: ");
                lijst[i] = int.Parse(Console.ReadLine());
            }

            return lijst;
        }
    }
}
