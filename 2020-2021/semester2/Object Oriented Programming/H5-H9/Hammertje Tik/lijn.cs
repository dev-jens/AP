using System;
using System.Collections.Generic;
using System.Text;

namespace Hammertje_Tik
{
    class Lijn : Vorm
    {
        public Lijn(int Xin , int Yin , int lengte) :base(Xin,Yin)
        {
            Lengte = lengte;
        }
        public int Lengte { get; set; }

        public override void TekenVorm()
        {
            Console.ForegroundColor = this.Kleur;
            for (int i = 0; i < Lengte; i++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.Write("*");
            }
            Console.ResetColor();
        }
        public override ConsoleColor Kleur => ConsoleColor.Green;
    }
}
