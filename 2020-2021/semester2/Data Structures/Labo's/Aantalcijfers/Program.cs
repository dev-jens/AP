using System;

namespace Aantalcijfers
{
    class Program
    {
        static int NumberOfDigits(int number)
        {
            if (number <10)
            {
                return 1;
            }

            return 1 + NumberOfDigits(number / 10);
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
