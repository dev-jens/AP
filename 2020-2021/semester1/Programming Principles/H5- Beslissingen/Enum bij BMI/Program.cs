using System;

namespace Enum_bij_BMI
{
    class Program
    {
        public enum gewichten {Ondergewicht, NormaalGewicht, Overgewicht, Obees, Zwaarlijvig, undefiend}

        static void Main(string[] args)
        {
            Console.Write("Wat is jou gewicht in kg: ");
            double gewicht = double.Parse(Console.ReadLine());

            Console.Write("Wat is jou lengte in meter (bv: 1.75)");
            double lengte = 1.70;//double.Parse(Console.ReadLine());

            double bmi = Math.Round(gewicht / Math.Pow(lengte, 2), 2);

            Console.WriteLine($"Je Bmi is {bmi} dit betekent dat:");

            gewichten soort =gewichten.undefiend;

            if (bmi < 18.5)
            {
              soort = gewichten.Ondergewicht;
            }
            else if (bmi < 24.9)
            {
                soort = gewichten.NormaalGewicht;
            }
            else if (bmi < 29.9)
            {
                soort = gewichten.Overgewicht;
            }
            else if (bmi < 39.9)
            {
                soort = gewichten.Obees;
            }
            else
            {
                soort = gewichten.Zwaarlijvig;
            }

            switch (soort)
            {
                case gewichten.Ondergewicht:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"je een ondergewicht hebt");
                    break;
                case gewichten.NormaalGewicht:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" je een normaal bmi hebt");
                    break;
                case gewichten.Overgewicht:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("je een overgewicht hebt. Je loopt niet echt een risico, maar je mag niet dikker worden.");
                    break;
                case gewichten.Obees:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("je overgewicht hebt(obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg  ");
                    break;
                case gewichten.Zwaarlijvig:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(" je ernstige zwaarlijvigheid bent. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).");
                    break;
                default:
                    break;
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
