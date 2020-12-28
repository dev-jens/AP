

using System;

namespace supercomputer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // vraag input komma getallen
            Console.WriteLine($"geef 3 komma getallen");
            Console.Write($"geef komma getal1: ");
            string getal1 = Console.ReadLine();
            Console.Write($"geef komma getal2: ");
            string getal2 = Console.ReadLine();
            Console.Write($"geef komma getal3: "); 
            string getal3 = Console.ReadLine();

            // parsen van string naar double
            double inputGetal1 = Convert.ToDouble(getal1);
            double inputGetal2 = double.Parse(getal2);
            double inputGetal3 = Convert.ToDouble(getal3);
            double gemiddeldeInput = (inputGetal1 + inputGetal2 + inputGetal3) / 3;

            // output van het gemiddelde
            Console.WriteLine($"het gemiddelde van de getallen die je ingevuld is {gemiddeldeInput}");





        }
    }
}
