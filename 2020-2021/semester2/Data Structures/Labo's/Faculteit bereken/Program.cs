using System;

namespace Faculteit_bereken
{
    class Program
    {
        static int Faculteit(int number)
        {
            if (number < 0)
                throw new Exception("negative number not correct");

            if (number == 0)
            {
                return 1;
            }

            return number * Faculteit(number - 1);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("geef een getal in ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("geef een getal2 in ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Faculteit van {num} is  {Faculteit(num)}");
            Console.WriteLine($"Aantal combinaties met 4 cijfers is {Faculteit(num) / Faculteit(num2)}");
        }
    }
}
