using System;

namespace Rekenmachine
{
    class Program
    {
        static double Telop(double getal1, double getal2)
        {
            return getal1 + getal2;
        }
        static double TrekAf(double getal1, double getal2)
        {
            return getal1 - getal2;
        }
        static double VermenigVuldig(double getal1, double getal2)
        {
            return getal1 * getal2;
        }
        static double Deel(double getal1, double getal2) 
        {
            return getal1 / getal2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculatrice");

            Console.Write("geef een getal: ");
            double getal1 = double.Parse(Console.ReadLine());
            Console.Write("geef een getal: ");
            double getal2 = double.Parse(Console.ReadLine());

            Console.Write("kies een opperator +, -, * , /");
            char opp = char.Parse(Console.ReadLine());
            switch (opp)
            {
                case '+':
                    Telop(getal1,getal2);
                    break;

                case '-':
                    TrekAf(getal1, getal2);
                    break;

                case '*':
                    VermenigVuldig(getal1, getal2);
                    break;

                case '/':
                    Deel(getal1, getal2);
                    break;
                default:
                    Console.WriteLine("WRONGGGGGGGG");
                    break;
            }   
        }
    }
}
