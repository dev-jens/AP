// Baeten Jens 1IT6

using System;

namespace Baeten_Jens_VAARDIG1
{
    class Program
    {
        enum soortStreamer {Beginner, Gevorderd, Faker, Onbekend}


        static void Main(string[] args)
        {
            
            const int CREDITKOST_VIEUWERS = 200;
            const int CREDITKOST_ADSPACE = 300;

            bool adspaceGekocht = false;
            int aantalGekochteVieuwers = 0;
            double vieuwers = 0;
            double creditScore = 0;

            //deel 1
            Random r = new Random();
            int aantalVieuwers = r.Next(1000, 6001);
            int budget = r.Next(100, 600);
            string gebruikersNaam = Environment.UserName;
            Console.WriteLine($"Welkom {gebruikersNaam} op APstream");
            Console.WriteLine($"Volgens onze data kijken er momenteel {aantalVieuwers}.Je budget is {budget} credits");

            //deel2
            Console.WriteLine("wat wil je doen?");
            Console.WriteLine("\t 1. koop 1000 vieuwers (200 credits)");
            Console.WriteLine("\t 2. koop adspace vieuwers (300 credits)");
            Console.WriteLine("\t 3.niets");
            int keuze = int.Parse(Console.ReadLine());

            switch (keuze)
            {
                case 1:
                    if (budget > CREDITKOST_VIEUWERS)
                    {
                        vieuwers = aantalVieuwers + 1000;
                        creditScore = budget - CREDITKOST_VIEUWERS;
                        Console.WriteLine($"vieuwers gekocht. je nieuwe statistieken zijn: {vieuwers} vieuwers en {creditScore} credits.");
                        aantalGekochteVieuwers = 1000;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" niet genoeg credits");
                    }
                    
                    break;
                case 2:
                    if (budget > CREDITKOST_ADSPACE)
                    {
                        adspaceGekocht = true;
                        creditScore = budget - 200; // in de opgave staat wordt verlaagd met 200
                        if (aantalVieuwers % 2000 == 0)
                        {
                            vieuwers = aantalVieuwers + 1000;
                        }
                        else
                        {
                            vieuwers = aantalVieuwers + 500;
                        }
                        Console.WriteLine($"adspace gekocht. je nieuwe statistieken zijn: {vieuwers} vieuwers en {creditScore} credits.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("niet genoeg credits");
                    }
                    break;
                case 3:

                    break;
                default:
                    double bewPrecentage = budget * 0.10;
                    double bewVieuwers = Math.Ceiling(aantalVieuwers * 0.25);

                    vieuwers = aantalVieuwers - bewVieuwers;
                    creditScore = budget - bewPrecentage;
                    Console.WriteLine($"dat is geen geldige keuze je verliest een kwart van je vieuwers (naar boven afgerond) en 10 procent van je budget  je finale statistieken zijn: {vieuwers} vieuwers en {creditScore:F2} credits");
                    break;
            }
            Console.ResetColor();

            //deel3
            soortStreamer soort = soortStreamer.Onbekend;

            if (vieuwers <= 4000 && creditScore <= 200)
            {
                soort = soortStreamer.Beginner;
            }
            else if (vieuwers >= 5000 && keuze <= 3)
            {
                soort = soortStreamer.Gevorderd;
            }
            else if (adspaceGekocht == true && vieuwers <=4000)
            {
                soort = soortStreamer.Faker;
            }
            else
            {
                soort =soortStreamer.Onbekend;
            }

            switch (soort)
            {
                case soortStreamer.Beginner:
                    Console.WriteLine("jouw streamer type is Beginner");
                    break;
                case soortStreamer.Gevorderd:
                    Console.WriteLine("jouw streamer type is Gevorderd");
                    break;
                case soortStreamer.Faker:
                    Console.WriteLine("jouw streamer type is Faker");
                    break;
                case soortStreamer.Onbekend:
                    Console.WriteLine("jouw streamer type is onbekend");
                    break;
                default:
                    Console.WriteLine("fout");
                    break;
            }

            if (soort == soortStreamer.Faker)
            {
                Console.WriteLine("wil je profiel om zetten naar gevorderde? (ja/nee):  ");
                string omzettenNaarGevorderde = Console.ReadLine();
                if (omzettenNaarGevorderde == "ja")
                {
                    Console.WriteLine("wordt beter!");
                }
            }
        }
    }
}
