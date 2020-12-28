using System;

namespace Casino
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
                Console.WriteLine("you WON");
            }
            else
            {
                Console.WriteLine("you lose");
            }
        }
    }
}
