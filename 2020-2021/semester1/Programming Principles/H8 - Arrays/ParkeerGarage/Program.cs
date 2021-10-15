using System;

namespace ParkeerGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel auto?: ");
            int input = int.Parse(Console.ReadLine());
          
           
            double[] uren = new double[input];
           
            for (int i = 0; i < uren.Length; i++)
            {
                Console.WriteLine($"geef parkeer tijd auto{i+1} in <uren>");
                uren[i] = double.Parse(Console.ReadLine());
            }
            PrintResultaat(uren);

            static void PrintResultaat(double[] uur)
            {
                double totaalUur = 0;
                double TotaalPrijs = 0;
                Console.WriteLine("auto\tuur\tprijs");
                for (int i = 0; i < uur.Length; i++)
                {
                    double prijs = BerkenenPrijs(uur[i]);
                    TotaalPrijs += prijs;
                    totaalUur += uur[i];

                    Console.WriteLine($"{i+1}\t{uur[i]}\t{prijs}");
                }
                Console.WriteLine($"totaalprijs = {TotaalPrijs}, totaal uur = {totaalUur}");
            }

            static double BerkenenPrijs(double uur)
            {
                double kost = 2;
                if (uur > 3)
                {
                    for (int i = 4; i <= uur; i++)
                    {
                        kost += 0.5;
                    }
                }
                if (uur >= 24)
                {
                    kost = 10;
                }

                return kost;
            }
        }
    }
}
