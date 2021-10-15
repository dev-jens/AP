using System;
using System.Collections.Generic;
using System.Text;

namespace Nummers
{
    class Nummers
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        public int Som()
        {
            return Getal1 + Getal2;
        }
        public int Verschil()
        {
            return Getal1 - Getal2;
        }
        public int Product ()
        {
            return Getal1 * Getal2;
        }
        public double Quotient()
        {
            if (Getal2 == 0)
            {
                Console.WriteLine("Kan niet delen door nul");
                return 0;
            }
            return (double)Getal1 / Getal2;
            
        }
    }
}
