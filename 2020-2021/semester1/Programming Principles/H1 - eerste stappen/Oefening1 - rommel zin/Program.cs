using System;

namespace Oefening1___rommel_zin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("wat is je favoriete kleur: ");
            string favKleur = Console.ReadLine();
            Console.Write("Wat eet je graag: ");
            string favEten = Console.ReadLine();
            Console.Write("Wat is je favoriete film: ");
            string favFilm = Console.ReadLine();
            Console.Write("Wat is je favoriete auto: ");
            string favAuto = Console.ReadLine();
            Console.WriteLine($"je favoriete kleur is {favAuto}. je eet graag {favFilm}. je favoriete film is {favEten}. je lievelings auto is {favKleur}. ");
                    
        }
    }
}
