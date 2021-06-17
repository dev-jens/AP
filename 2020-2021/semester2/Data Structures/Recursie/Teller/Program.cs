using System;

namespace Teller
{
    class Program
    {
        static void UpCounter(int num)
        {
            
            if (num == 1)
            {
                Console.WriteLine(num);
                return;
            }

            UpCounter(num - 1);
            Console.WriteLine(num);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("geef een getal in ");
            int num = int.Parse(Console.ReadLine());

            UpCounter(num);
        }
    }
}
