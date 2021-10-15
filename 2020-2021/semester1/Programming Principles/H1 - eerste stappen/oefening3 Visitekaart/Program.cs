using System;

namespace oefening3_Visitekaart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("wat is je voor + achternaam: ");
            string volledigeNaam = Console.ReadLine();

            Console.Write("wat is je adres: ");
            string adres = Console.ReadLine();

            Console.Write("wat is je hobby: ");
            string hobby = Console.ReadLine();

            Console.Write("Waarom deze opleiding volgen?: ");
            string waaromIT = Console.ReadLine();

            Console.Write("Waarom AP ?: ");
            string waaromAP = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Naam: {volledigeNaam}");
            Console.WriteLine($"Adres: {adres}");
            Console.WriteLine($"Hobby: {hobby}");
            Console.WriteLine($"Waarom deze opleiding volgen?: {waaromIT}");
            Console.WriteLine($"Waarom AP?: {waaromAP}");


        }
    }
}
