using System;
using ZoekAlgoritmes.LinearSearchh;

namespace ZoekAlgoritmes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welk zoekAlgoritme wilt u testen?");
            Console.WriteLine();
            Console.WriteLine("A: Linear Search ,B: Binary Search ,C: Hash");
            string input = Console.ReadLine().ToUpper();

            switch (input)
            {
                case "A":
                    LinearSearchTester.Start();
                    break;
                case "B":

                    break;
                case "C":
                   
                    break;
                //case "D":
                //    
                //    break;
                //case "E":
                //    
                //    break;
                //case "F":
                //   
                //    break;
                default:
                    break;
            }
        }
    }
}
