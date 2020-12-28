using System;

namespace GewitchOpPlaneet
{
    class Program
    {
        static void Main(string[] args)
        {
            double mijnGewicht = 70;
            double gewichtOpAarde = 1 * mijnGewicht;
            double gewichtMercurius = 0.38 * mijnGewicht;
            double gewichtVenus = 0.91 * mijnGewicht;
            double gewichtMars = 0.38 * mijnGewicht;
            double gewichtJupiter = 2.34 * mijnGewicht;
            double gewichtSaturnus = 1.06 * mijnGewicht;
            double gewichtUranus = 0.92 * mijnGewicht;
            double gewichtNeptunus = 1.19 * mijnGewicht;
            double gewichtPluto = 0.06 * mijnGewicht;
            Console.WriteLine($"je weegt op Mercurius {gewichtMercurius} kg");
            Console.WriteLine($"je weegt op venus {gewichtVenus} kg");
            Console.WriteLine($"je weegt op mars {gewichtMars} kg");
            Console.WriteLine($"je weegt op Jupiter {gewichtJupiter} kg");
            Console.WriteLine($"je weegt op Saturnus {gewichtSaturnus} kg");
            Console.WriteLine($"je weegt op Uranus   {gewichtUranus} kg");
            Console.WriteLine($"je weegt op Neptunus {gewichtNeptunus} kg");
            Console.WriteLine($"je weegt op Pluto {gewichtPluto} kg");



        }
    }
}
