using System;

namespace LeveringsBedrijf
{
    class Program
    {
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        static void Main(string[] args)
        {
            // constante
            const int LEN = 10;
            // ramdom postcode  gen
            Random r = new Random();
            
          
            // arrays
            int[] postcodes = new int[LEN];
            int[] prijsPerkg = new int[LEN];

            for (int i = 0; i < postcodes.Length; i++)
            {
                int ramdomPostcode = r.Next(200, 300) * 10;
                postcodes[i] = ramdomPostcode;
            }

            for (int i = 0; i < prijsPerkg.Length; i++)
            {
                int ramdomPrijsPerKg = r.Next(1, 100);
                prijsPerkg[i] = ramdomPrijsPerKg;
            }
            Print(postcodes);
            Console.WriteLine("\n");
            Print(prijsPerkg);
            
            Console.Write("\ngeef een gewicht: ");
            double gewicht = double.Parse(Console.ReadLine());
            Console.Write("\ngeef een postcode: ");
            int postcode = int.Parse(Console.ReadLine());
            double product = 0;
            for (int i = 0; i < postcodes.Length; i++)
            {
                if (postcodes[i] == postcode )
                { 
                    product = prijsPerkg[i] * gewicht;

                }
            }
            if (product !=0)
            {
                Console.WriteLine("\nje eind totaal is " + product);
            }
            else
            {
                Console.WriteLine("\nniet gevonden");
            }

        }
    }
}
