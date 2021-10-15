using System;
using System.Collections.Generic;
using System.Text;

namespace Boek
{
    class Boek
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Auteur { get; set; }

        private double prijs;

        public  virtual double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }

        static Boek Telop(Boek b1 , Boek b2)
        {
            var result = new Boek();
            result.Auteur = $"Omnibus van {b1.Auteur} , {b2.Auteur}";
            result.prijs = (b1.prijs + b2.prijs) / 2;

            return result;
        }
        public override string ToString()
        {
            return $"{Title} - {Auteur}({ISBN} {prijs})";
        }

    }
}
