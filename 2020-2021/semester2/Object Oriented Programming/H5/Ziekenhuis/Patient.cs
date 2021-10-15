using System;
using System.Collections.Generic;
using System.Text;

namespace Ziekenhuis
{
    class Patient
    {
        public string Naam { get; set; }
        public int AantalUur { get; set; }

        public virtual double Berekenkost()
        {
            int basis = 50;
            return basis + (20 * AantalUur);
        }

        public void ToonInfo()
        {
            Console.WriteLine("naam " + Naam + " kost = " +  Berekenkost());
        }
    }
}
