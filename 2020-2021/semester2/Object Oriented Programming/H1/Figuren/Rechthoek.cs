using System;
using System.Collections.Generic;
using System.Text;

namespace Figuren
{
    class Rechthoek
    {

        private int lengte;

        public int Lengte
        {
            get { return lengte; }
            set { if(value > 1)lengte = value; }
        }

        private int breedte;

        public int Breedte
        {
            get { return breedte; }
            set { if(value > 1)breedte = value; }
        }

        public void ToonOpp()
        {
            Console.WriteLine($"opp Rechthoek : {lengte* breedte}");
        }
    }
}
