using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Orakel_van_Delphi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Wat is je geslacht vul in (m of v): ");
            string geslacht = Console.ReadLine().ToLower();

            Console.Write("Wat is je Leeftijd: ");
            int leeftijd = int.Parse(Console.ReadLine());

            int maxM = 120;
            int maxV = 150;
            int max = 0;

            if (geslacht == "m")
            {
                max = maxM - leeftijd;
            }
            else
            {
                max = maxV - leeftijd;
            }

            Random r = new Random();
            int rLeeftijd = r.Next(5, max);

            Console.WriteLine($"je leeft nog {rLeeftijd}");
            
        }
    }
}
