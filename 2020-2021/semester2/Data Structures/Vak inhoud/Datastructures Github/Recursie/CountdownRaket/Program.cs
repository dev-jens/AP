using System;

namespace CountdownRaket
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

                    Countdown(getal);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// deze functie telt in de console af vanaf het gegeven getal naar 0. 
        /// Bij 0 wordt 'Takeoff' getoond.
        /// TakeOff(3) => 3 2 1 Take-off!    <= 3 + TakeOff(2)
        /// TakeOff(2) =>   2 1 Take-off!    <= 2 + TakeOff(1)
        /// TakeOff(1) =>     1 Take-off!    <= 1 + TakeOff(0)
        /// TakeOff(0) =>       Take-off!    <= base-case
        /// </summary>
        /// <param name="number">getal groter of gelijk aan 0</param>
        static void Countdown(int number)
        {
            if (number < 0)
                throw new Exception("Het getal moet groter zijn dan -1");

            if (number == 0)
            {
                Console.WriteLine("Take-off !");
                return;
            }

            Console.Write($"{number}.. ");
            Countdown(number - 1);
        }
    }
}
