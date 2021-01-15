using System;

namespace LeveringsBedrijf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] postcode = { 2960, 2970, 2660, 2970, 2990, 2980, 2000, 2100,2180, 2930};
            double[] prijsPerKG = { 1.3, 2.2, 2.5, 2.6, 2.21, 3.1, 5.2, 4.2, 3.6 , 1.6 };

            Console.Write("Geef de postcode van uw adres: ");
            int postAdres = int.Parse(Console.ReadLine());

            Console.Write("Wat is het gewicht van het paketje");
            double gewicht = double.Parse(Console.ReadLine());

            int indexPost = -1;
            bool found = false; 

            for (int i = 0; i < postcode.Length; i++)
            {
                if (postcode[i] == postAdres)
                {
                    found = true;
                    indexPost = i;
                    Console.WriteLine("we hebben hem");
                }
                
            }

            if (found)
            {
                double prijs = prijsPerKG[indexPost] * gewicht;
                Console.WriteLine($"dit zal {prijs} euro kosten");
            }
            else
            {
                Console.WriteLine("niet gevonden");
            }

        }
    }
}
