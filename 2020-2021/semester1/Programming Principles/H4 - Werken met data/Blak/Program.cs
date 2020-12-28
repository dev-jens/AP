using System;

namespace Blak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"oppervlakte en omtrek berekenen van een balk");
            // ask input + convert input
            Console.Write($"geef de lengte: ");
            string inputLengte = Console.ReadLine();
            double Lengte = double.Parse(inputLengte);

            Console.Write($"geef de breedte: ");
            string inputBreedte = Console.ReadLine();
            double Breedte = double.Parse(inputLengte);  

            Console.Write($"geef de hoogte: ");
            string inputHoogte = Console.ReadLine();
            double hoogte = double.Parse(inputLengte);

            double oppervlakte = 2 * (Breedte * hoogte) + 2 * (Breedte * Lengte) + 2 * (hoogte * Lengte);
            double inhoud = Breedte * hoogte * Lengte;

            //Console.WriteLine($"Lengte: {inputLengte}");
            //Console.WriteLine($"Breedte: {inputBreedte}");
            //Console.WriteLine($"Hoogte: {inputHoogte}");
            Console.WriteLine($"opppervlakte: {oppervlakte}");
            Console.WriteLine($"inhoud: {inhoud}");
        }
    }
}
