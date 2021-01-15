using System;

namespace Methoden_deel2_film
{
    class Program
    {
        enum typeGenre {Actie , Thriller, Anime, Onbekend }

        // film
        static void FilmRunTime(string naam, int duur = 90 , typeGenre genre = typeGenre.Onbekend)
        {
            Console.WriteLine($"{naam} ({duur} minuten ,{genre})");
        }

        // module 1 
      
        static double rekenmachine(double a , double b, string oppper)
        {
            double resultaat = 0;
            switch (oppper)
            {
                case "+":
                    resultaat = a + b;
                    break;
                case "-":
                    resultaat = a - b;
                    break;
                case "*":
                    resultaat = a * b;
                    break;
                case "/":
                    resultaat = a / b;
                    break;
                default:
                    break;
            }
            return resultaat;
        }


        static void Main(string[] args)
        {
            FilmRunTime("matrix");
            FilmRunTime("matrix", 120);
            FilmRunTime("matrix", 120, typeGenre.Actie);
            FilmRunTime(duur: 120, naam: "coolkidz", genre: typeGenre.Anime);


            // module 1 afsluiter 

            Console.WriteLine("Welke applicatie wilt u runnen");
            Console.WriteLine("Menuitem 1 - Rekenmachine");
            Console.WriteLine("Menuitem 2 - Password tester");
            Console.WriteLine("..............");





        }
      
        
    }
}
