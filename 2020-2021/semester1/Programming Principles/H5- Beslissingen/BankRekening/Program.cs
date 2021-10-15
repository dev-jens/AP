using System;

namespace BankRekening
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef eerst 3 cijfers iban: ");
            string eersteCijfers3 = Console.ReadLine();
            Console.Write("geef nu de volgende 7cijfers: ");
            string middelste7cijfers = Console.ReadLine();
            Console.Write("geef de laatse 2 cijfers: ");
            int laatstCijfers2 = int.Parse(Console.ReadLine());

            string strEerste10 = eersteCijfers3 + middelste7cijfers;
            double ibanEerste10 = Convert.ToDouble(strEerste10);
          
            if (ibanEerste10 % 97 == laatstCijfers2)
            {
                Console.WriteLine("dit is een geldig iban nummer");
            }
            else
            {
                Console.WriteLine("dit is een ongeldig iban nummer");
            }
            
        }
    }
}
