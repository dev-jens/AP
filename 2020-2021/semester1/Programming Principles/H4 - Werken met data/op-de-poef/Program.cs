using System;

namespace op_de_poef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("voer een bedrag in:");
            double bedrag1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat op {bedrag1} euro.");

            Console.WriteLine("voer een bedrag in:");
            double bedrag2 = double.Parse(Console.ReadLine());
            double somBedrag2 = bedrag1 + bedrag2;
            Console.WriteLine($"De poef staat op {somBedrag2} euro.");

            Console.WriteLine("voer een bedrag in:");
            double bedrag3 = double.Parse(Console.ReadLine());
            double somBedrag3 = somBedrag2 + bedrag3; 
            Console.WriteLine($"De poef staat op {somBedrag3} euro.");

            Console.WriteLine("voer een bedrag in:");
            double bedrag4 = double.Parse(Console.ReadLine());
            double somBedrag4 = somBedrag3 + bedrag4;
            Console.WriteLine($"De poef staat op {somBedrag4} euro.");


            Console.WriteLine("voer een bedrag in:");
            double bedrag5 = double.Parse(Console.ReadLine());
            double somBedrag5 = somBedrag4 + bedrag5;
            Console.WriteLine($"De poef staat op {somBedrag5} euro.");
        }
    }
}
