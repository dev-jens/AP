using System;

namespace Enum
{
    class Program
    {
        enum gewichten {Ondergewicht,Normaal, Overgewicht,Zwaarlijvig,Ernstig , Onbekend };

        static void Main(string[] args)
        {
            Console.Write("Wat is gewicht?:  ");
            int gewicht = int.Parse(Console.ReadLine());
            Console.Write("Wat is je lengte in (180) cm: ");
            int lengte = int.Parse(Console.ReadLine());

            gewichten soortGewicht = gewichten.Onbekend;
            double bmi = gewicht * Math.Pow(lengte,2);

            if (bmi <= 18.5)
            {
                soortGewicht = gewichten.Ondergewicht;
            }
            else if (bmi < 25)
            {
                soortGewicht = gewichten.Normaal;
            }
            else if (bmi < 30)
            {
                soortGewicht = gewichten.Overgewicht;
            }
            else if (bmi < 40)
            {
                soortGewicht = gewichten.Zwaarlijvig;
            }
            else if(bmi > 40)
            {
                soortGewicht = gewichten.Ernstig;
            }

            switch (soortGewicht)
            {
                case gewichten.Ondergewicht:
                    Console.WriteLine("ondergewicht");
                    break;
                case gewichten.Normaal:
                    Console.WriteLine("ondergewicht");

                    break;
                case gewichten.Overgewicht:
                    Console.WriteLine("overgewicht");

                    break;
                case gewichten.Zwaarlijvig:
                    Console.WriteLine("ewaarlijvig");

                    break;
                case gewichten.Ernstig:
                    Console.WriteLine("ernstig overgewicht");

                    break;
                case gewichten.Onbekend:
                    Console.WriteLine("onbekend");

                    break;
                default:
                    break;
            }
        }
    }
}
