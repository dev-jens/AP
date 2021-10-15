using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 0;
            while (getal != -1)
            {
                try
                {
                    Console.WriteLine("Het hoeveelste fibonacci number wil u berekenen ?");
                    var input = Console.ReadLine();

                    if (!int.TryParse(input, out getal))
                        throw new Exception("Dit is geen geldig getal, probeer opnieuw AUB");

                    var fibonr = FibonacciNumber(getal);
                    Console.WriteLine($"Het {getal}e fibonacci nummer is {fibonr}");

                    FibonacciSerie(getal);
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Het zoveelste Fibonaccigetal berekenen
        /// Fibonacci(5) = Fibonacci(4) + Fibonacci(3)
        /// Fibonacci(4) = Fibonacci(2) + Fibonacci(2)
        /// Fibonacci(3) = Fibonacci(2) + Fibonacci(1)
        /// Fibonacci(2) = Fibonacci(1) + Fibonacci(0)
        /// Fibonacci(1) = 1        <= base case
        /// Fibonacci(0) = 1        <= base case
        /// 
        /// </summary>
        /// <param name="getal"></param>
        /// <returns></returns>
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
    }
}
