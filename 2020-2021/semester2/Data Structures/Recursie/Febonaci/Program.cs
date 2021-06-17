using System;

namespace Febonaci
{
    class Program
    {
        static int FibonacciNumber(int n)
        {
            if (n < 0)
                throw new Exception("n moet groter of gelijk aan 0 zijn");
            if (n == 0 || n == 1)
                return n;

            return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
        }


        static void FibonacciSerie(int n)
        {
            if (n < 0)
                throw new Exception("n moet groter of gelijk aan 0 zijn");

            if (n == 0)
                Console.Write($"{FibonacciNumber(n)} - ");
            else
            {
                Console.Write($"{FibonacciNumber(n)} - ");
                FibonacciSerie(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Het hoeveelste fibonacci number wil u berekenen ?");
            var input = int.Parse(Console.ReadLine());


            Console.WriteLine($"febonqci van {input} = {FibonacciNumber(input)}");
            FibonacciSerie(input);
        }

        
    }
}