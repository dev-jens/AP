using System;

namespace Persoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon jens = new Persoon();
            Persoon felix = new Persoon();
            Persoon mrPeePeePooPoo = new Persoon();

            Console.WriteLine("jens");
            jens.GeboorteDatum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(jens.Leeftijd);

            Console.WriteLine("jens");
            felix.GeboorteDatum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(felix.Leeftijd);

            Console.WriteLine("jens");
            mrPeePeePooPoo.GeboorteDatum = DateTime.Parse(Console.ReadLine());
            
        }
    }
}
