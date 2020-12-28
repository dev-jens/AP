using System;

namespace WiskundeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            const int RAMDOM_START = 1;
            const int RAMDOM_END = 11;
           
            Random r = new Random();

            bool gameloop = true;
            int juisteAntwoorden = 0;      

            while (gameloop)
            { 
                int getal1 = r.Next(RAMDOM_START, RAMDOM_END);
                int getal2 = r.Next(RAMDOM_START, RAMDOM_END);
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
            }
            Console.WriteLine($" jammer het is gedaaan je had er {juisteAntwoorden}");
            Console.ReadKey();
            
        }
    }
}
