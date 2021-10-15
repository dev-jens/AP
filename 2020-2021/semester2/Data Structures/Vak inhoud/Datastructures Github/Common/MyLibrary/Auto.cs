using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Auto : IComparable<Auto>
    {
        public string Model { get; set; }
        public string Kleur { get; set; }
        public int Bouwjaar { get; set; }
        public int AantalKm { get; set; }
        public Brandstof Brandstof { get; set; }


        public int CompareTo(Auto other)
        {
            if (other == null)
                return 1;
            if (this.AantalKm > other.AantalKm)
                return 1;
            if (this.AantalKm < other.AantalKm)
                return -1;

            return 0;
        }
        public override string ToString()
        {
            return $"{Model} (kleur: {Kleur}, bj:{Bouwjaar}, km:{AantalKm})";
        }

    }

    public enum Brandstof
    { 
        Benzine,
        Diesel,
        Electriciteit,
        Waterstof
    }

}
