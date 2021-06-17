using System;

namespace Faculteit_berekenen
{
    class Program
    {
        static int faculteit(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * faculteit(num - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("geef een getal in ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("geef een getal2 in ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Faculteit van {num} is  {faculteit(num)}");
            Console.WriteLine($"Aantal combinaties met 4 cijfers is {faculteit(num)/faculteit(num2)}");


        }
    }
}
