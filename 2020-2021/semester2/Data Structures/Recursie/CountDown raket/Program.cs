using System;

namespace CountDown_raket
{
    class Program
    {

        static void Countdown(int num)
        {

            if (num == 0)
            {
                Console.WriteLine("Take off");
                return;
            }

            Console.Write($"{num}..");
            Countdown(num - 1);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("geef een getal in ");
            int num = int.Parse(Console.ReadLine());

            Countdown(num);
        }
    }
}
