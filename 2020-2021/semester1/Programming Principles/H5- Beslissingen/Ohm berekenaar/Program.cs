using System;

namespace Ohm_berekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Wat wilt u berekenen?");

            Console.Write("1 = weerstand, 2 = stroomstrekte, 3 = spanning: ");
            int input = int.Parse(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    Console.WriteLine("weerstand berkenen");

                    Console.Write("geef stroomstrekte: ");
                    double stroomsterkte = int.Parse(Console.ReadLine());

                    Console.Write("geef spanning: ");
                    double spanning = int.Parse(Console.ReadLine());

                    double weerstand = stroomsterkte / spanning;

                    Console.WriteLine($"de weerstand is {weerstand} ohm");
                    break;

                case 2:
                    Console.WriteLine("stroomsterkte berekenen");

                    Console.Write("geef spanning: ");
                    spanning = int.Parse(Console.ReadLine());

                    Console.Write("geef weerstand: ");
                    weerstand = int.Parse(Console.ReadLine());

                    stroomsterkte = spanning / weerstand;

                    Console.WriteLine($"de strooomsterkte is {stroomsterkte} ampére");

                    break;

                case 3:
                    Console.WriteLine("spanning berkenen");

                    Console.Write("geef stroomstrekte: ");
                    stroomsterkte = int.Parse(Console.ReadLine());

                    Console.Write("geef weerstand: ");
                    weerstand = int.Parse(Console.ReadLine());

                    spanning = weerstand / stroomsterkte;
                    Console.WriteLine($"de spanning is {spanning} volt");
                    break;
            }


        }
    }
}
