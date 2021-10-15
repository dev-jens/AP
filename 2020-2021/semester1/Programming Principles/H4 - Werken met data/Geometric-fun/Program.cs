using System;

namespace Geometric_fun
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("geef een hoek in radialen: ");
            string inputHoek = Console.ReadLine();
            double hoek = double.Parse(inputHoek);

            double hoekRad = hoek * (Math.PI / 180);
            double sinus = Math.Sin(hoekRad);
            double cosinus = Math.Cos(hoekRad);
            double tangens = Math.Tan(hoekRad);

            Console.WriteLine($"hoek in radialen: {hoekRad}");
            Console.WriteLine($"Sinus: {sinus} ");
            Console.WriteLine($"Cosinus: {cosinus} ");
            Console.WriteLine($"Tangens: {tangens} ");


        }
    }
}
