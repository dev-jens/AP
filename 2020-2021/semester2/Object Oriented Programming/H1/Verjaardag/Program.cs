using System;

namespace Verjaardag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef je verjaardag bv (18/03) << ");
            DateTime verjaardag = DateTime.Parse(Console.ReadLine());

            if (verjaardag < DateTime.Today)
            {
                verjaardag = verjaardag.AddYears(1);
            }

            TimeSpan dagenover = verjaardag - DateTime.Today;

            Console.WriteLine($"Je verjaart over {dagenover.Days} dagen");

        }
    }
}
