using System;

namespace Pokemon_overide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class Pokemon
        {
            public string Naam { get; set; }
            public int level { get; set; }
            public int basstatis { get; set; }
            public override bool Equals(object obj)
            {

                if (obj is Pokemon)
                {
                    Pokemon teVgl = obj as Pokemon;
                    if (this.Naam == teVgl.Naam)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
