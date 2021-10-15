using System;

namespace Prijzen_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prijzen = new int[5];
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine($"Geef prijs {i}:");
                prijzen[i] = Convert.ToInt32(Console.ReadLine());
            }
            int som = 0;
            foreach (var price in prijzen)
            {
                som += price;
                if (price >= 5)
                {
                    Console.WriteLine(price);
                }
            }

            Console.WriteLine("gemiddelde is " + som/prijzen.Length);

        }
    }
}
