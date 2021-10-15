using System;

namespace Euro_naar_dollar
{
    class Program
    {
        static void Main(string[] args)
        {
            int Euro = 50;
            double koersRatio = 1.1677;

            double euroNaarDollar = Euro * koersRatio;

            Console.WriteLine($"{Euro} euro is gelijk aan {euroNaarDollar} dollar");


        }
    }
}
