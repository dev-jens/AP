using System;

namespace Hamming_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoelang is je dna string");
            int lengte = int.Parse(Console.ReadLine());

            char[] dnaString1 = new char[lengte];
            char[] dnaString2 = new char[lengte];

            Console.WriteLine($"geef een dna string van {lengte}");
            for (int i = 0; i < dnaString1.Length; i++)
            {
                dnaString1[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"geef een 2de dna string van {lengte}");
            for (int i = 0; i < dnaString2.Length; i++)
            {
                dnaString2[i] = char.Parse(Console.ReadLine());
            }

        }
    }
}
