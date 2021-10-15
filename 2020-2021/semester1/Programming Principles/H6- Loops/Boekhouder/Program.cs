using System;

namespace Boekhouder
{
    class Program
    {
        static void Main(string[] args)
        {
            int neg = 0;
            int pos = 0;
            int i = 0;
            int balans = 0;
            double gemiddelde = 0;



            while (true)
            {
                Console.Write("voer een getal in: ");
                int input = int.Parse(Console.ReadLine());

                // ballans ingevoerde getallen 
                balans += input;

                //positieve bewerking
                if (input > 0)
                {
                    pos += input;
                }
                else //negative bewerking
                {
                    neg += input;
                }

                // gemiddelde
                i++;
                gemiddelde = balans / i;

                Console.WriteLine($"De balans is: {balans}");
                Console.WriteLine($"Aantal negatieve getallen: {neg}");
                Console.WriteLine($"Aantal positieve getallen: {pos}");
                Console.WriteLine($"Gemiddelde: {gemiddelde}");
            }
        }
    }
}
