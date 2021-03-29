using System;

namespace BankManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Rekening tim = new Rekening();
            tim.StortGeld(1000);
            Rekening student = new Rekening();
            do
            {
                Console.WriteLine("Hoeveel geld wil je naar de student overschrijven ?");
                int bedrag = int.Parse(Console.ReadLine());

                student.StortGeld(tim.HaalGeldAf(bedrag));

                tim.ToonBalans();
                student.ToonBalans();

            } while (true);
        }
    }
}
