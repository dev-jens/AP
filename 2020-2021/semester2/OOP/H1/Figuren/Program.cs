using System;

namespace Figuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Driehoek driehoekeruuu = new Driehoek() {Breedte =5 , Lengte = 3};
            Rechthoek rechthoeker = new Rechthoek() {Breedte = 6, Lengte = 3 };

            driehoekeruuu.ToonOpp();
            rechthoeker.ToonOpp();

        }
    }
}
