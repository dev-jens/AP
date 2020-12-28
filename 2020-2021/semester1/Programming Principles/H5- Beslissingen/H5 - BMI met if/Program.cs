using System;

namespace H5___BMI_met_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is jou gewicht in kg: ");
            double gewicht = double.Parse(Console.ReadLine());

            Console.Write("Wat is jou lengte in meter (bv: 1.75)");
            double lengte = 1.70;//double.Parse(Console.ReadLine());

            double bmi = Math.Round(gewicht / Math.Pow(lengte, 2), 2);

            Console.WriteLine($"Je Bmi is {bmi} dit betekent dat:");

            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"je een ondergewicht hebt");
               
            }
            else if (bmi < 24.9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" je een normaal bmi hebt");
                
            }
            else if (bmi < 29.9)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("je een overgewicht hebt. Je loopt niet echt een risico, maar je mag niet dikker worden.");
                
            }
            else if (bmi <39.9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("je overgewicht hebt(obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg  ");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" je ernstige zwaarlijvigheid bent. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).");
                
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
    

