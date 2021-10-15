using System;

namespace AantalCijfers
{
    class Program
    {
        static void Main(string[] args)
        {
            long getal = 0;
            while (getal != -1)
            {
                try
                {
                    Console.WriteLine("Geef een getal in");
                    var input = Console.ReadLine();

                    if (!long.TryParse(input, out getal))
                        throw new Exception("Dit is geen geldig getal, probeer opnieuw AUB");

                    Console.WriteLine($"Het aantal cijfers in {getal} is {NumberOfDigits(getal)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }

        /// <summary>
        /// Bereken het aantal cijfers in een gegeven getal
        /// NumberOfDigits(2305) => 4 = 1 + NumberOfDigits(2905 / 10)
        /// NumberOfDigits(230) => 3  = 1 + NumberOfDigits(290 / 10)
        /// NumberOfDigits(23) => 2   = 1 + NumberOfDigits(29 / 10)
        /// NumberOfDigits(2) => 1    = base case
        /// </summary>
        /// <param name="number">een getal</param>
        /// <returns></returns>
        static int NumberOfDigits(long number)
        {
            if (number < 10 && number > -10)
                return 1;

            return 1 + NumberOfDigits(number / 10);
        }
    }
}
