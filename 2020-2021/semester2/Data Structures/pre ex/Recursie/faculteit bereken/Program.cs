using System;

namespace faculteit_bereken
{
    class Program
    {
        static void Main(string[] args)
        {
            int faculteit(int number)
            {
                int fac = 0;
                // exit condition
                if (number <= 0)
                {
                    return 1;
                }
                fac = number * faculteit(number - 1);
                return fac;
            }

            Console.WriteLine($"geef een getal in groter of gelijk is aan 0 ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"faculteit van {input} is {faculteit(input)}");
            Console.WriteLine($"het aantal combinaties met 4 cijfers is {faculteit(10)/faculteit(6)}");
        }
    }
}
