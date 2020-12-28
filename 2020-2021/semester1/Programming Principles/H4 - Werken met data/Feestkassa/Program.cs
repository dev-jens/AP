using System;

namespace Feestkassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("frietjes? ");
            int frietjes = int.Parse(Console.ReadLine());
            int prijsFrietjes = frietjes * 20;
            Console.WriteLine($"tussenprijs = {prijsFrietjes} euro");

            Console.WriteLine("koninginnenhapje? ");
            int koninghapjes = int.Parse(Console.ReadLine());
            int prijsKoninghapjes = koninghapjes * 10;
            Console.WriteLine($"tussenprijs = {prijsFrietjes} euro + {prijsKoninghapjes} euro");

            Console.WriteLine("ijsjes? ");
            int ijsjes = int.Parse(Console.ReadLine());
            int prijsIjsjes = ijsjes * 3;
            Console.WriteLine($"tussenprijs = {prijsFrietjes} euro + {prijsKoninghapjes} euro {prijsIjsjes} euro");

            Console.WriteLine("dranken? ");
            int dranken = int.Parse(Console.ReadLine());
            int prijsDranken = dranken * 2;
            Console.WriteLine($"tussenprijs = {prijsFrietjes} euro + {prijsKoninghapjes} euro + {prijsIjsjes} + euro {prijsDranken} euro");
            Console.WriteLine("");
            Console.WriteLine($"het totaal te betalen bedrag is {prijsFrietjes + prijsDranken + prijsKoninghapjes + prijsIjsjes} euro.");

        }
    }
}
