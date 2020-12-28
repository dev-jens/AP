using System;
using System.Runtime.InteropServices.ComTypes;

namespace Schaak
{
    class Program
    {
        public enum kleur {zwart, wit}
        public enum stuk { Toren, Paard, Loper, Koning, Koningin, Pion }

        static void Main(string[] args)
        {
            Random r = new Random();
            kleur kleurID = (kleur)r.Next(0, Enum.GetNames(typeof(kleur)).Length);
            stuk stukID = (stuk)r.Next(0, Enum.GetNames(typeof(stuk)).Length);

            kleur kleurID2 = (kleur)r.Next(0, Enum.GetNames(typeof(kleur)).Length);
            stuk stukID2 = (stuk)r.Next(0, Enum.GetNames(typeof(stuk)).Length);

            kleur kleurID3 = (kleur)r.Next(0, Enum.GetNames(typeof(kleur)).Length);
            stuk stukID3 = (stuk)r.Next(0, Enum.GetNames(typeof(stuk)).Length);

            Console.WriteLine($"{kleurID} {stukID}");
            Console.WriteLine($"{kleurID2} {stukID2}");
            Console.WriteLine($"{kleurID3} {stukID3}");


        }
    }
}
