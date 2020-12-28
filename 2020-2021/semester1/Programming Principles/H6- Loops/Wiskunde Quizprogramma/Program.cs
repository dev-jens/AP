using System;
using System.Threading;

namespace Wiskunde_Quizprogramma
{
    class Program
    {
        static void Main(string[] args)
        {

            const int RAMDOM_START = 1;
            Random r = new Random();

            bool oefenen = false;
            bool gameloop = true;
            int juisteAntwoorden = 0;
            int level = 1;

            Console.Write("kies een spel 1-Gewoon spelen, 2-Starten op een bepaald level, 3-oefenen");
            int keuzeSpel = int.Parse(Console.ReadLine());
            switch (keuzeSpel)
            {
                case 1:
                    Console.WriteLine("veel plezeier met gewoon spelen");
                    break;
                case 2:
                    Console.Write("geef een level");
                    level = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    oefenen = true;
                    break;
                default:
                    Console.WriteLine("ai no man is niet goed !!");
                    gameloop = false;
                    break;
            }

            
                while (gameloop)
                {
                int input = 0;
                    int mexLevel = 5 * Convert.ToInt32(Math.Pow(2, level - 1));
                    int getal1 = r.Next(RAMDOM_START, mexLevel);
                    int getal2 = r.Next(RAMDOM_START, mexLevel);
                    int product = getal1 * getal2;
                
                if (oefenen)
                {
                    Console.WriteLine($"{getal1} * {getal2} = {product} ");
                    input = product;
                    Thread.Sleep(5000); //sleep 5sec
                    
                }
                else
                {
                    Console.Write($"{getal1} * {getal2} =  ");
                    input = int.Parse(Console.ReadLine());
                }

                if (input == product)
                    {
                        juisteAntwoorden++;
                    }
                    else
                    {
                        Console.WriteLine("u sucky suc");
                        gameloop = false;
                    }
                    if (juisteAntwoorden % 5 == 0)
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
