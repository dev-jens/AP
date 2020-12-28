using System;

namespace Casino_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int rGetal = r.Next(1, 7);

            Console.WriteLine("Raad een getal tussen 1 & 6: ");
            int guess = int.Parse(Console.ReadLine());

            if (rGetal == guess)
            {
                rGetal = r.Next(1, 7);
                Console.WriteLine("je hebt 1/3 raad nog een keer:");
                int guess2 = int.Parse(Console.ReadLine());

                if (rGetal == guess2)
                {
                    rGetal = r.Next(1,7);
                    Console.WriteLine("je hebt 2/3 raad nog een keer: ");
                    int guess3 = int.Parse(Console.ReadLine());

                    if (rGetal == guess3)
                    {
                        Console.WriteLine("you win");

                    }
                    else
                    {
                        Console.WriteLine("you lose");
                    }
                }
                else
                {
                    Console.WriteLine("you lose");
                }    
            }
            else
            {
                Console.WriteLine("you lose");
            }
        }
    }
}
