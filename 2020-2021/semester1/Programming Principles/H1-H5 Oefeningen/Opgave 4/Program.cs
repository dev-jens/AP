using System;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je ooen?");
            Console.WriteLine("Covidbeslissinghelper(c) of de Covidquiz(q)");
            char keuze = char.Parse(Console.ReadLine());

            switch (keuze)
            {
                case 'q':
                    Console.WriteLine("vertoon je symptomen?; ");
                    char vertoonSymptomen = char.Parse(Console.ReadLine());
                    Console.Clear();
                    char nauwContact = ' ';

                    if (vertoonSymptomen == 'n')
                    {
                        Console.WriteLine("in nou contact geweest met iemand die ziek is?");
                        nauwContact = char.Parse(Console.ReadLine());
                        Console.Clear();

                        if (nauwContact == 'n')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("je mag naar school blijven gaan");
                        }
                    }
                    if (vertoonSymptomen == 'j' || nauwContact == 'j' )
                    {
                        Console.WriteLine("ga in quarantaine en laat je testen");
                        Console.WriteLine("positieve test ? ");
                        char covidTest = char.Parse(Console.ReadLine());
                        Console.Clear();

                        if (covidTest == 'j')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("naar school wanneer genezen");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("7dagen in quarantaine");
                        }
                    }
                    
                    
                    break;
                case 'c':
                    const int GETAL1 = 1;
                    const int GETAL2 = 6;

                    Random r = new Random();
                    int ramdomGetal = r.Next(GETAL1, GETAL2);

                    Console.WriteLine($"je bent al {ramdomGetal} dagen in quarantaine");
                    Console.WriteLine("hoeveel dagen nog voor je te laten testen");
                    int dagenTotTest = int.Parse(Console.ReadLine());
                    Console.Clear();
                    int oplossing = ramdomGetal - 1;

                    if (dagenTotTest == oplossing)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("fout ");
                    }

                    break;
                default:
                    Console.WriteLine("je hebt een fout ingevoerd: ");
                    break;
            }
            Console.ResetColor();
        }
    }
}
