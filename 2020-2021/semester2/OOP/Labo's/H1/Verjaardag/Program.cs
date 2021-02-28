using System;

namespace Verjaardag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je geboorte datum(DD/MM): ");
            DateTime verjaardag = DateTime.Parse(Console.ReadLine());

            if (verjaardag < DateTime.Today)
            {
                verjaardag = verjaardag.AddYears(1);
            }

            TimeSpan dagenVoorVerj = verjaardag - DateTime.Today;
            Console.WriteLine($"je verjaart over {dagenVoorVerj} dagen");
        }
    }
}
