using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin_Advanced
{
    abstract class dier
    {
        private int gewicht = 50;

        public int Gewicht
        {
            get { return gewicht; }
            set { gewicht = value; }
        }

        public abstract void Zegt();

    }

    class Koe : dier
    {
        public override void Zegt()
        {
            Console.WriteLine("moooeeee");
        }
    }
    class Slang : dier
    {
        public override void Zegt()
        {
            Console.WriteLine("ssssssssss");
        }
    }
    class Varken : dier
    {
        public override void Zegt()
        {
            Console.WriteLine("blub");
        }
    }
}
