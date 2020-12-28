using System;

namespace Vraag_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vragenLijst = {
                "Hoeveel letters heeft je naam?", 
                "Hoe oud ben je?",
                "Wat is je postcode?",
                "Wat is je geboorte jaar?",
                "hoeveel uur heb je vandaag geprogrameerd?",
            };

            int[] antwoordenVragenLijst = new int[vragenLijst.Length];

            for (int i = 0; i < vragenLijst.Length; i++)
            {
                Console.WriteLine(vragenLijst[i]);
                antwoordenVragenLijst[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("antwoorden");
            for (int i = 0; i <vragenLijst.Length; i++)
            {
                Console.WriteLine($"{vragenLijst[i]}: {antwoordenVragenLijst[i]}");
            }
            
        }
    }
}
