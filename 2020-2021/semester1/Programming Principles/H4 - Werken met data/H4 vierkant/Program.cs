using System;

namespace H4_vierkant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"oppervlakte en omtrek berekenen :");
            Console.Write($"geef de lengte van de zijde: ");
            string inputZijde = Console.ReadLine();
            double zijdeToDouble = double.Parse(inputZijde);
            double omtrek = Math.Pow(zijdeToDouble, 4.0);
            double opppervlakte = zijdeToDouble * 2;

            Console.WriteLine($"Zijde: {zijdeToDouble}");
            Console.WriteLine($"omtrek: {omtrek}");
            Console.WriteLine($"oppervlakte: {opppervlakte}");

        }
    }
}
