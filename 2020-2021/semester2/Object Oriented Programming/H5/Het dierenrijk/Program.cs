using System;
using System.Collections.Generic;

namespace Het_dierenrijk
{
    class Program
    {
        static void Main(string[] args)
        {
            var alleBeestjes = new List<Animal>();
            alleBeestjes.Add(new Animal() { NaamBeest = "Dodo", IsUitgestorven = true });
            alleBeestjes.Add(new Cow() { NaamBeest = "Milkakoe", KleurVlekken = "Paars" ,Biotoop = "weide" });
            alleBeestjes.Add(new Snake() { NaamBeest = "Cobra", HeeftRattelstaart = false });
            alleBeestjes.Add(new Snake() { NaamBeest = "Ratelslang", HeeftRattelstaart = true });

            foreach (var beest in alleBeestjes)
            {
                beest.ToonInfo();
            }
        }

        class Animal
        {
            public string NaamBeest { get; set; }
            public bool IsUitgestorven { get; set; } 
            public virtual void ToonInfo()
            {
                Console.WriteLine($"****{NaamBeest}****");
                if (IsUitgestorven)
                    Console.WriteLine("Dit dier is uitgestorven");
                else Console.WriteLine("Dit dier is niet uitgestorven");
            }
        }

        class Mammal : Animal
        {
            public string Biotoop { get; set; }
            public override void ToonInfo()
            {
                base.ToonInfo();
                Console.WriteLine($"En heeft als biotoop:{Biotoop}");
            }
        }

        class Rabbit : Mammal
        {
            public int LengteOren { get; set; }
            public override void ToonInfo()
            {
                base.ToonInfo();
                Console.WriteLine($"De lengte van dit konijn z'n oren is {LengteOren}");
            }
        }
        class Cow : Mammal
        {
            public string KleurVlekken { get; set; }
            public override void ToonInfo()
            {
                base.ToonInfo();
                Console.WriteLine($"Deze koe heeft {KleurVlekken} vlekken");
            }
        }
        class Dog : Mammal { }
        class Reptile : Animal { }
        class Snake : Reptile
        {
            public bool HeeftRattelstaart { get; set; }
            public override void ToonInfo()
            {
                base.ToonInfo();
                if (HeeftRattelstaart)
                    Console.WriteLine("Deze slang heeft een ratelstaart");
                else Console.WriteLine("Deze slang heeft geen ratelstraat");
            }
        }
        class Iguana : Reptile { }





    }
}
