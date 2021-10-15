using System;

namespace Geometrische_Figuren
{
    class Program
    {
        static void Main(string[] args)
        {
            var rechtHoek = new Rechthoek();

            var V1 = new Vierkant(2);
            Vierkant vierkan = new Vierkant(2, 3);

            var driehoek = new Driehoek();

            rechtHoek.height = 5;
            rechtHoek.width = 4;
            driehoek.height = 4;
            driehoek.width = 3;

            Console.WriteLine("rechthoek" + rechtHoek.BereknOPP());

            Console.WriteLine("v" + V1.BereknOPP());
            Console.WriteLine(vierkan.BereknOPP());
           

            Console.WriteLine("Dreihoke" + driehoek.BereknOPP());

        }

        abstract class GeoFigure
        {
            public int height { get; set; }
            public int width { get; set; }
           
            public double Oppervlakte
            {
                get { return BereknOPP(); }
           
            }

            public abstract double BereknOPP();

        }

        class Rechthoek : GeoFigure
        {
            public override double BereknOPP()
            {
                return height * width;
            }
        }

        class Vierkant : Rechthoek
        {
            public Vierkant(int h , int w)
            {
                if (h != w)
                {
                    w = h;
                }
                height = h;
                width = w;
            }
            public Vierkant(int side)
            {
                height = width = side;
            }

        }

        class Driehoek : GeoFigure
        {
            public override double BereknOPP()
            {
                return (height * width) / 2;
            }
        }
    }
}
