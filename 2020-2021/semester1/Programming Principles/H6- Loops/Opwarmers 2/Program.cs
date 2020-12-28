using System;

namespace Opwarmers_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("geef een getal: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input);
            while (input != 0)
            {
                Console.Write("geef een getal: ");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine(input);
            }


        }
    }
}
