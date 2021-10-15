using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("H13 Dierentuin");
            List<dier> dieren = new List<dier>();
            dieren.Add(new Slang());
            dieren.Add(new Slang());
            dieren.Add(new Koe());
            dieren.Add(new Varken());

            string answer = "";
            while (answer != "q")
            {
                Console.WriteLine("wat wilt u doen?");
                Console.WriteLine("a = verwijder, b = gemiddelde gewicht, c = praten, d = opnieuw opstarten, e = kies prater , q = stoppen ");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "a":
                        Console.WriteLine($"op welke plaats wilt u het verwijderen van 0 tot {dieren.Count}");
                        int nummer = Convert.ToInt32(Console.ReadLine());
                        if (nummer < dieren.Count)
                            dieren.RemoveAt(nummer);
                        else
                            Console.WriteLine("Dat nummer bestaat niet");
                        break;
                    case "b":
                        int totaal = 0;
                        foreach (var animal in dieren)
                        {
                            totaal += animal.Gewicht;
                        }
                        double gemiddelde = totaal / dieren.Count;
                        Console.WriteLine("gemiddelde gewicht = " + gemiddelde);
                        break;
                    case "c":
                        foreach (var animal in dieren)
                        {
                            animal.Zegt();
                        }
                        break;
                    case "d":
                        dieren.Clear();
                        break;
                    case "e":
                        Console.WriteLine("geef S= salng , v= varken , K = koe");
                        string dierkeuze = Console.ReadLine();
                        switch (dierkeuze)
                        {
                            case "S":
                                foreach (var dier in dieren)
                                {
                                    if (dier is Slang)
                                    {
                                        (dier as  Slang).Zegt();
                                    }
                                }
                                break;
                            case "K":
                                foreach (var dier in dieren)
                                {
                                    if (dier is Koe)
                                    {
                                        (dier as Koe).Zegt();
                                    }
                                }
                                break;
                            case "V":
                                foreach (var dier in dieren)
                                {
                                    if (dier is Varken)
                                    {
                                        (dier as Varken).Zegt();
                                    }
                                }
                                break;
                            default:
                                break;
                        }

                        break;
                    default:
                        break;
                }

            }
        }
    }
}
