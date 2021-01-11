using System;

namespace oefeningen_voor_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            // veel voorkomende variablen
            const int AFSLUITWAARDE = -32768;
            int input = 0;
            int som = 0;
            int aantal = 0;
            double gem = 0;

            Console.Write("kies een oefening van 6-..");
            int keuze = int.Parse(Console.ReadLine());



            switch (keuze)
            {
                case 6:
                 ;
                    do
                    {
                        Console.Write("geef een getal: >> ");
                        input = int.Parse(Console.ReadLine());

                        if (input >= 0)
                        {
                            som += input;
                            aantal++;
                        }

                    } while (input >= 0);
                    gem = som / aantal;

                    Console.WriteLine($"het gemiddelde is: {gem}");
                    break;

                case 7:

                    do
                    {
                        Console.Write("geef een getal: >>");
                        input = int.Parse(Console.ReadLine());

                    } while (input != AFSLUITWAARDE);
                  


                    break;
                default:
                    break;
            }
        }
    }
}
