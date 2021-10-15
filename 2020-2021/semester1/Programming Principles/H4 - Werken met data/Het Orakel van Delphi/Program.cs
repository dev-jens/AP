using System;

namespace Het_Orakel_van_Delphi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int ramdomLeeftijd = r.Next(5, 126);

            Console.WriteLine($"je zal nog {ramdomLeeftijd} jaar leven");
        }
    }
}
