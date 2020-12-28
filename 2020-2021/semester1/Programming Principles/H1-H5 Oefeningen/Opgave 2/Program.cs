using System;
using System.Globalization;

namespace Opgave_2
{
    class Program
    {
        enum Fases { A, B, C, Onbekend }


        static void Main(string[] args)
        {
            string fase = " ";

            Console.WriteLine("Zet de computer aan");
            Console.Write("gaat de computer aan?(j/n) >> ");
            string input = Console.ReadLine();
            Console.Clear();

            if (input == "j")
            {
                Console.Write("Zijn er fout boodschappen?(j/n) ");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "j")
                {
                    fase = "A";
                }
                else
                {
                    fase = "B";
                }
            }
            else
            {
                Console.Write("Gaat het power light aan?(j/n) >>");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "j")
                {
                    Console.WriteLine("zet het computer scherm aan ");
                }
                else
                {
                    Console.WriteLine("Controleer de voedings kabel");
                }
                Console.Clear();

                Console.Write("Is het probleem opgelost?(j/n) ");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "j")
                {
                    fase = "B";
                }
                else
                {
                    fase = "C";
                }
            }

            switch (fase)
            {
                case "A":
                    Console.Write("voer het getal van de foutcode in(0-9) >>");
                    int foutCode = int.Parse(Console.ReadLine());

                    if (foutCode >= 0 && foutCode <= 9)
                    {
                        double bew = Math.Sqrt(foutCode * 3);
                        double X = Math.Round(bew, 2) ;
                        Console.WriteLine($"{X} verschijnt op het scherm met 1 cijfer na de komma.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("LOS HET DAN ZELF OP STINK HOER");
                    }
                    break;

                case "B":
                    const int BEGIN = 1;
                    const int EINDE = 101;
                    Random r = new Random();
                    int winGetal = r.Next(BEGIN, EINDE);
                    Console.Write("mooi zo alles werkt" );

                    if (winGetal >= 1 && winGetal <= 25 )
                    {
                        Console.WriteLine("En u wint ook nog eens 1 jaar gratis IT support!");
                    }

                    break;
                case "C":
                    
                    int processorCount = Environment.ProcessorCount;
                    int processorBew = processorCount * 50;
                    bool is_64Bit = Environment.Is64BitOperatingSystem;
                    if (processorCount == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{processorCount} processor");
                        Console.WriteLine($"{processorBew} euro");
                    }
                    else if (processorCount > 1) 
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{processorCount} processor");
                        Console.WriteLine($"{processorBew} euro");

                        if (processorCount >= 5)
                        {
                            Console.WriteLine("200 euro");
                        }
                    }
                    if (is_64Bit == true)
                    {
                        Console.WriteLine("hier is een bon");
                    }
                    break;
                default:
                    Console.WriteLine("je hebt een fout ingevuld start opnieuw WEES AANDACHTIG");
                    break;
            }
            Console.ResetColor();

        }
    }
}
