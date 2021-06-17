using System;

namespace Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            void Upcounter(int number)
            {

                // Exit condition
                if (number <= 0)
                {
                    return;
                }
                Upcounter(number-1);
                Console.WriteLine(number);

            }
           Upcounter(5);
        }
    }
}
