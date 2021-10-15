using System;

namespace Teller
{
    class Program
    {
        static void Upcounter(int number)
        {
            if (number == 1)
            {
                 Console.WriteLine(1);
                return;
            }
            
            Upcounter(number - 1);
            Console.WriteLine(number);

        }

        static void Main(string[] args)
        {
            Upcounter(6);
        }
    }
}
