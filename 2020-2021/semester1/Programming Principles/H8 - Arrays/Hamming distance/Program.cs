using System;

namespace Hamming_distance
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Geef DNA string 1");
            char[] dna1 = Console.ReadLine().ToCharArray();
            Console.WriteLine("Geef DNA string 2");
            char[] dna2 = Console.ReadLine().ToCharArray();
            int disntace = 0;
            if (dna1.Length == dna2.Length)
            {
                for (int i = 0; i < dna1.Length; i++)
                {
                    if (dna1[i] == dna2[i])
                    {
                        Console.Write(" ");
                        disntace++;
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine($"\n de hamming disntace = {disntace}");
            }
            else
            {
                Console.WriteLine("foute lengte");
            }
          
        }
    }
}
