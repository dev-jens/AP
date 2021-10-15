using System;

namespace wiskunde_Quiz_met_levels
{
    class Program
    {
        static void Main(string[] args)
        {
            const int RAMDOM_START = 1;
            

            Random r = new Random();

            bool gameloop = true;
            int juisteAntwoorden = 0;
            int level = 1;

            while (gameloop)
            {
                int mexLevel = 5 * Convert.ToInt32(Math.Pow(2, level - 1));
                int getal1 = r.Next(RAMDOM_START,mexLevel);
                int getal2 = r.Next(RAMDOM_START,mexLevel);
                int product = getal1 * getal2;

                Console.Write($"{getal1} * {getal2} =  ");
                int input = int.Parse(Console.ReadLine());

                if (input == product)
                {
                    juisteAntwoorden++;
                }
                else
                {
                    Console.WriteLine("u sucky suc");
                    gameloop = false;
                }
                if (juisteAntwoorden %5 == 0)
                {
                    level++;
                    Console.WriteLine($"level up, je bent nu level {level}");
                }
            }


            Console.WriteLine($" jammer het is gedaaan je had er {juisteAntwoorden} en je was {level}");
            Console.ReadKey();
        }
    }
}
