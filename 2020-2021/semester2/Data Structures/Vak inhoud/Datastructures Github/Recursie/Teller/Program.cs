using System;

namespace Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 0;
            while (getal != -1)
            {
                try
                {
                    Console.WriteLine("Geef een getal in groter dan 0");
                    var input = Console.ReadLine();

                    if (!int.TryParse(input, out getal))
                        throw new Exception("Dit is geen geldig getal, probeer opnieuw AUB");

                    Console.WriteLine();
                    UpCounter(getal);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Deze functie telt in de console op tot het gegeven getal. 
        /// Counter(3) => 1 2 3  <= Counter(2) + 3
        /// Counter(2) => 1 2    <= Counter(1) + 2
        /// Counter(1) => 1      <= base-case
        /// </summary>
        /// <param name="number">getal groter dan 0</param>
        static void UpCounter(int number)
        {
            if (number <= 0)
                throw new Exception("Het getal moet groter zijn dan 0");

            if (number == 1)
            {
                Console.WriteLine($"{number} ");
                return;
            }

            UpCounter(number - 1);
            Console.WriteLine($"{number} ");
        }
    }
}
