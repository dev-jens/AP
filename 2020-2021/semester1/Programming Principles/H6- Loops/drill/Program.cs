using System;

namespace drill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Toon alle getallen die een veelvoud van 3 zijn en oneven zijn tot en met 100.

            //const int N = 100;

            //for (int i = 0; i <= N; i+= 3)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Toon alle machten tot 5 van n.

            //const int N = 10;
            //const int macht = 5;
            //double machtBerkening;

            //for (int i = 0; i < N; i++)
            //{
            //    machtBerkening = Math.Pow(i,macht);
            //    Console.WriteLine($"{i} tot de {macht} = {machtBerkening}");
            //}



            //Console.Write("geef een getal: ");
            //int maalTafel = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= maalTafel; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write($"{i}X{j}={i*j},");

            //    }
            //    Console.WriteLine("");
            //}

            const double TELLER = 1.0;
            double som = 0;

            Console.Write("geef een getal: ");
            int maalTafel = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= maalTafel; i++)
            {
                Console.Write($" {TELLER}/{i} + ");
                double berkeningSom = (TELLER / i);

                som += berkeningSom;
                
            }

            Console.WriteLine("");
            Console.WriteLine($"dit is de som {som}");














        }
    }
}
