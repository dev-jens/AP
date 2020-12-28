using System;

namespace Simple_maths
{
    class Program
    {
        static void Main(string[] args)
        {
            // with integer
            int som1 = -1 + 4 * 6;
            int som2 = (35 + 5) % 7;
            int som3 = 14 + -4 * 6 / 11;
            int som4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.Write($"-1 + 4 * 6 = {som1} \n(35 + 5) % 7 = {som2} \n");
            Console.Write($"14 + -4 * 6 / 11 = {som3} \n2 + 15 / 6 * 1 - 7 % 2 = {som4}");

            Console.WriteLine("");
            Console.WriteLine("");

            // with double
            double som5 = -1 + 4 * 6;
            double som6 = (35 + 5) % 7;
            double som7 = 14 + -4 * 6 / 11;
            double som8 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.Write($"-1 + 4 * 6 = {som5} \n(35 + 5) % 7 = {som6} \n");
            Console.Write($"14 + -4 * 6 / 11 = {som7} \n2 + 15 / 6 * 1 - 7 % 2 = {som8}");
        }
    }
}
