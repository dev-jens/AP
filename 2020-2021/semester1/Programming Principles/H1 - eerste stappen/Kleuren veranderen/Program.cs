using System;

namespace Kleuren_veranderen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("wat is je favoriete kleur: ");
            string favKleur = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Wat eet je graag: ");
            string favEten = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Wat is je favoriete film: ");
            string favFilm = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Wat is je favoriete auto: ");
            string favAuto = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"je favoriete kleur is {favAuto}. ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"je eet graag {favFilm}. ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"je favoriete film is {favEten}. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"je lievelings auto is {favKleur}. ");

            Console.ResetColor();
        }
    }
}
