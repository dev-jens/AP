using System;
using System.Collections.Generic;

namespace SpeelKaarten
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Speelkaart> BoekKaarten = new List<Speelkaart>();
            for (int i = 0; i < 4; i++)
            {
                for (int J = 1; J < 14; J++)
                {
                    BoekKaarten.Add(new Speelkaart() {Getal=J,Suite=(Suit)J });
                }
            }

            Random r = new Random();

            while (BoekKaarten.Count > 0)
            {
                Speelkaart getrokken = BoekKaarten[r.Next(0,BoekKaarten.Count)];
                Console.WriteLine("Getrokken kaart=");
                Console.WriteLine($"{getrokken.Suite}  {getrokken.Getal}");
                BoekKaarten.Remove(getrokken);
                Console.ReadKey();
            }

        }

        enum Suit { Schoppen, Harten, Klaveren, Ruiten }

        class Speelkaart
        {
            public int Getal { get; set; }
            public Suit Suite { get; set; }

        }
    }
}
