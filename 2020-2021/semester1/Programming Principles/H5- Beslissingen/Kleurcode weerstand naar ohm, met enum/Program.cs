using System;
using System.Xml.XPath;

namespace Kleurcode_weerstand_naar_ohm__met_enum
{
    class Program

    {
         enum kleuren { zilver = -2, goud,    zwart,   bruin,   rood,    oranje,  geel,    groen,   blauw,   paars,  grijs,   wit , undefiend}

        static void Main(string[] args)
        {
           
            Console.Write("ring1 ?");
            string input1 = Console.ReadLine().ToLower();
            Console.Write("ring2 ?");
            string input2 = Console.ReadLine().ToLower();
            Console.Write("ring3 ?");
            string input3 = Console.ReadLine().ToLower();

            
            kleuren kleur1 = kleuren.undefiend;
            kleuren kleur2 = kleuren.undefiend;
            kleuren  kleur3 = kleuren.undefiend;
           
            //ring1
            switch (input1)
            {
                case "zwart":
                    kleur1 = 0;
                    break;
                case "bruin":
                    kleur1 = kleuren.bruin;
                    break;
                case "rood":
                    kleur1 = kleuren.rood;
                    break;
                case "orangje":
                    kleur1 = kleuren.oranje;
                    break;
                case "geel":
                    kleur1 = kleuren.geel;
                    break;
                case "groen":
                    kleur1 = kleuren.groen;
                    break;
                case "blauw":
                    kleur1 = kleuren.blauw;
                    break;
                case "paars":
                    kleur1 = kleuren.paars;
                    break;
                case "grijs":
                    kleur1 = kleuren.grijs;
                    break;
                case "wit":
                    kleur1 = kleuren.wit;
                    break;
                default: break;
            }
            int ring1 = (int)kleur1;

            switch (input2)
            {
                case "zwart":
                    kleur2 = kleuren.zwart;
                    break;
                case "bruin":
                    kleur2 = kleuren.bruin;
                    break;
                case "rood":
                    kleur2 = kleuren.rood;
                    break;
                case "orangje":
                    kleur2 = kleuren.oranje;
                    break;
                case "geel":
                    kleur2 = kleuren.geel;
                    break;
                case "green":
                    kleur2 = kleuren.groen;
                    break;
                case "blauw":
                    kleur2 = kleuren.blauw;
                    break;
                case "paars":
                    kleur2 = kleuren.paars;
                    break;
                case "grijs":
                    kleur2 = kleuren.grijs;
                    break;
                case "wit":
                    kleur2 = kleuren.wit;
                    break;
                default: break;

            }
            int ring2 = (int)kleur2;
            switch (input3)
            {
                case "zwart":
                    kleur3 = kleuren.zwart;
                    break;
                case "bruin":
                    kleur3 = kleuren.bruin;
                    break;
                case "rood":
                    kleur3 = kleuren.rood;
                    break;
                case "orangje":
                    kleur3 = kleuren.oranje;
                    break;
                case "geel":
                    kleur3 = kleuren.geel;
                    break;
                case "green":
                    kleur3 = kleuren.groen;
                    break;
                case "blauw":
                    kleur3 = kleuren.blauw;
                    break;
                case "paars":
                    kleur3 = kleuren.paars;
                    break;
                case "grijs":
                    kleur3 = kleuren.grijs;
                    break;
                case "wit":
                    kleur3 = kleuren.wit;
                    break;
                default: break;
            }
            int mult = (int)kleur3;

            double oplossing = ((ring1 * 10) + ring2) * Math.Pow(10, mult);
            Console.WriteLine(oplossing);
                

        }
    }
}
