using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            uitgverij stand = new uitgverij();
            uitgverij pelck = new uitgverij();

            stand.Setboeken(50);
            stand.SetMagazines(60);
            pelck.Setboeken(50);
            pelck.SetMagazines(90);

            stand.AantalGelezen = 50;
            pelck.AantalGelezen = 40;
            Console.WriteLine(stand.MagScore());
            Console.WriteLine(pelck.MagScore());
            Console.WriteLine(pelck.boekScore());
            Console.WriteLine(stand.boekScore());
        }
        class uitgverij
        {
            public static int boeken = 5;
            public static int Magazine = 10;
            public int AantalGelezen = 0;

            public void Setboeken(int aantal)
            {
                boeken = aantal;
            }
            public void SetMagazines(int aantal)
            {
                Magazine = aantal;
            }
            public int boekScore()
            {
                return AantalGelezen + boeken;
            }
            public int MagScore()
            {
                return AantalGelezen + Magazine;
            }
        }
    }
}
