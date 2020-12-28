using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is jou gewicht in kg: ");
            double gewicht = double.Parse(Console.ReadLine());

            Console.Write("Wat is jou lengte in meter (bv: 1.75)");
            double lengte = double.Parse(Console.ReadLine());

            double bmi = Math.Round(gewicht / Math.Pow(lengte, 2),2);
            

            Console.WriteLine($"jouw gewicht is: {gewicht}");
            Console.WriteLine($"jouw lengte is: {lengte}");
            Console.WriteLine($"jouw bmi is dan: {bmi}");
        }
    }
}
