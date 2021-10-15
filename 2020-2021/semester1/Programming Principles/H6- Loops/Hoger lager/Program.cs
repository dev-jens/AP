using System;
using System.Globalization;

namespace Hoger_lager
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GOK_GRENS = 10;
            bool gameloop = true;
            Random r = new Random();
            int RamdomGetal = r.Next(1,101);
            int aantalKeuzes = 0;
            int input = 0;
            do
            {
                do
                {
                    Console.Write("gok een getal tussen 1 & 100: >");
                    input = int.Parse(Console.ReadLine());

                    if (input > RamdomGetal)
                    {
                        Console.WriteLine("lager :) ");
                    }
                    else if (input < RamdomGetal)
                    {
                        Console.WriteLine(" hoger :)");
                    }


                    aantalKeuzes++;
                } while (aantalKeuzes < GOK_GRENS && input != RamdomGetal);

                if (input == RamdomGetal)
                {
                    Console.WriteLine("Winner winner chicken dinner");
                }
                else
                {
                    Console.WriteLine("meedoen is belangrijker dan winnen");
                }

                Console.WriteLine($"je hebt {aantalKeuzes} keren geraden, het getal was {RamdomGetal}");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("wilde of wilde ni opnieuw spelen a zebi:(J of N) ");
                char keuzeSpel = char.Parse(Console.ReadLine());

                if (keuzeSpel == 'N')
                {
                    gameloop = false;
                }

            } while (gameloop);

            Console.WriteLine("CYA NERD");
            

        }
    }
}
