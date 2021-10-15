using System;

namespace Faculteit
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
                    Console.WriteLine("Geef een getal in groter of gelijk aan 0");
                    var input = Console.ReadLine();

                    if (!int.TryParse(input, out getal))
                        throw new Exception("Dit is geen geldig getal, probeer opnieuw AUB");

                    Console.WriteLine($"faculteit van {getal} is {Faculteit(getal)}");

                    Console.WriteLine($"het aantal combinaties met 4 cijfers is {Faculteit(10) / Faculteit(6)}");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Bereken de faculteit van een gegeven getal
        /// n! = n * (n-1)!
        /// fact (3) = 3 * 2 * 1 maw. fact (3) = 3 * fact(2)
        /// fact (2) =     2 * 1 maw. fact (2) = 2 * fact(1)
        /// fact (1) =         1 = base case
        /// </summary>
        /// <param name="number">een postitief getal</param>
        /// <returns></returns>
        static int Faculteit (int number)
        {
            if (number < 0)
                throw new Exception("het getal mag niet kleiner zijn dan 0");
            if (number == 0 || number == 1)
                return 1;

            return number * Faculteit(number - 1);
        }
    }
}
