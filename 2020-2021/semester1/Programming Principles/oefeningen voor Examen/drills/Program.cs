using System;

namespace drills
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef een dril keuze in ints");
            int keuze = int.Parse(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    Console.WriteLine("geef een getal: >>");
                    int getal = int.Parse(Console.ReadLine());
                    int aantal = 0;
                    while (getal != 0)
                    {
                        getal = getal / 10;
                        aantal++;
                    }
                    Console.WriteLine(aantal);
                    break;
                case 2:
                    char c ;
                   // Console.WriteLine("geef n: ");
                   // int n = int.Parse(Console.ReadLine());
                    for (int i =97; i < 123; i++)
                    {
                        c = Convert.ToChar(i);
                        Console.Write(c);
                 
                    }
                    break;

                case 3:
                    Console.Write("geef een getal: >>>");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write("geef de macht= >> ");
                    int macht = int.Parse(Console.ReadLine());
                    int power = 1;
                    for (int i = 0; i < macht; i++)
                    {
                        power *= n;
                    }
                    Console.WriteLine($"{n} tot de {macht} macht is {power}");
                    break;
                default:
                    break;
            }
           
        }
    }
}
