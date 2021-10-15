using System;
using System.Collections.Generic;
using System.Text;

namespace Hammertje_Tik
{
    abstract class Vorm
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void TekenVorm();
        public virtual ConsoleColor Kleur { get; } = ConsoleColor.Red; 

        public Vorm (int Xin, int Yin)
        {
            X = Xin;
            Y = Yin;
        }

    }
}
