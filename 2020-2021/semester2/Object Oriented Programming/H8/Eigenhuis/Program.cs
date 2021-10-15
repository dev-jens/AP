using System;
using System.Collections.Generic;

namespace Eigenhuis
{
    class Program
    {
        static void Main(string[] args)
        {
            Huis Myhouse = new Huis();
            Myhouse.lijstKamers.Add(new salon() { Heefschauw = true });
            Myhouse.lijstKamers.Add(new gang() { Oppervlakte = 100  });
            Myhouse.lijstKamers.Add(new BadKamer());

            Console.WriteLine(Myhouse.BerekenPrijs());
        }


        class Huis
        {
            public List<kamer> lijstKamers = new List<kamer>();

            public int BerekenPrijs()
            {
                int totaal = 0;
                foreach (var kamer in lijstKamers)
                {
                    totaal += kamer.prijs;
                }
                return totaal;
            }


        }
        class kamer
        {
            public string Naam { get; set; }
            public int Oppervlakte { get; set; }
            public virtual int prijs { get; set; } = 400;
        }

        class BadKamer:kamer
        {
            public override int prijs 
            {
               get => 500; 
               
            }
        }
        class salon:kamer
        {
            public bool Heefschauw { get; set; }
            public override int prijs 
            {
                get 
                {
                    if (Heefschauw)
                    {
                        return 500;
                    }
                    return 300; 
                } 
            
            }
        }
        class gang:kamer
        {
            public override int prijs { get =>  Oppervlakte*10 ; }
        }
    }
}
