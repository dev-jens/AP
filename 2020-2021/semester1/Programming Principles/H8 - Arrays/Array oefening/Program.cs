using System;
using System.Collections;
using System.Threading;

namespace Array_oefening
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleColor[] kerstSlinger = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Red };

            Random r = new Random();
            while (true)
            {
                ToonSlinger(kerstSlinger,r.Next(1,Console.WindowWidth), r.Next(1, Console.WindowHeight));
                System.Threading.Thread.Sleep(500);
            }

      




        }
        static void ToonSlinger(ConsoleColor[] slingerIn, int startX , int startY)
        {
            Console.SetCursorPosition(startX, startY);

            for (int i = 0; i < slingerIn.Length; i++)
            {
                ConsoleColor tijdelijk = slingerIn[i];
                Console.ForegroundColor = tijdelijk;
                Console.Write("*");
            }
            Console.ResetColor();
        }
    }
}
