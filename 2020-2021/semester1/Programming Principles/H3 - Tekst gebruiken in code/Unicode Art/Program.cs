using System;

namespace Unicode_Art
{
    class Program
    {
        static void Main(string[] args)
        {
            string unicodeArt = "┌∩┐(◣_◢)┌∩┐";
            Console.WriteLine($"{unicodeArt}");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("┌∩┐");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("(◣_◢)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("┌∩┐");
            Console.ResetColor();

        }
    }
}
