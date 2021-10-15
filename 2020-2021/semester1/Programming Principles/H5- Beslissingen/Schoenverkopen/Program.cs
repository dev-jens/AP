using System;

namespace Schoenverkopen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hoeveel bedraagt de korting:");
            int korting = int.Parse(Console.ReadLine());
            int prijs;
            Console.Write("hoeveel schoenen koopt u:");
            int aantalSchoenen = int.Parse(Console.ReadLine());

            if (aantalSchoenen <= korting)
            {
                prijs = aantalSchoenen * 20;
                Console.WriteLine($"{aantalSchoenen} schoenen kost {aantalSchoenen} x 20 = {prijs}");
            }
            else
            {
                int verschilSchoenen = aantalSchoenen - korting;
                prijs = korting*20 + verschilSchoenen*10;
                Console.WriteLine($"{aantalSchoenen} schoenen kost {korting} x 20 + {verschilSchoenen} x 10 = {prijs}");
            }


        }
    }
}
