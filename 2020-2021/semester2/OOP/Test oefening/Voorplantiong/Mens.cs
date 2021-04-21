using System;
using System.Collections.Generic;
using System.Text;

namespace Voorplantiong
{
    public enum geslacht {Man, Vrouw }
    public enum kleur_ogen {Blauw, Bruin,Groen, Rood}

    class Mens
    {
        static Random r = new Random();

        public Mens()
        {
            int lengteCatogorie = r.Next(0, 101);

            if (lengteCatogorie >= 90)
                maxlengte = r.Next(150, 211);
            else if (lengteCatogorie >= 95)
                maxlengte = r.Next(40, 151);
            else
                maxlengte = r.Next(210, 241);
        }
        public Mens(geslacht ges, kleur_ogen kleur, int maxLen)
        {
            geslacht = ges;
            oogKleur = kleur;
            Maxlengte = maxLen;
        }

        public geslacht geslacht { get; set; }
        public kleur_ogen oogKleur { get; set; }

        private int maxlengte;

        public int Maxlengte
        {
            get { return maxlengte; }
            set { if (value >= 30) maxlengte = value; }
        }

        public void ToonMens() 
        {
            switch (oogKleur)
            {
                case kleur_ogen.Blauw:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case kleur_ogen.Bruin:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case kleur_ogen.Groen:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case kleur_ogen.Rood:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{maxlengte/100 :0.00} m, {geslacht}");
        }

    }
}
