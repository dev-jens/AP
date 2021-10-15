using System;

namespace Coundown_raket
{
    class Program
    {
         static void Countdown(int num)
        {
            if (num < 0)
            {
                throw new Exception("Het getal moet groter zijn dan -1");
            }
            if (num == 0)
            {
                Console.Write("Take-Off");
                return;
            }

            Console.Write(num + "..");
            Countdown(num-1);
        }

        static void Main(string[] args)
        {
            Countdown(5);
        }
    }
}
