using System;
using System.Collections.Generic;
using System.Text;

namespace Hammertje_Tik
{
    class Rechthoek : Vorm
    {
        public int Lengte { get; set; }
        public int Breedte { get; set; }

        public Rechthoek() : base(1,1)
        {
            Breedte = 2;
            Lengte = 2;
        }
        public override ConsoleColor Kleur => ConsoleColor.Yellow;
        public Rechthoek(int xin , int yin , int brdte , int len):base(xin,yin)
        {
            Breedte = brdte;
            Lengte = len;

        }

        public override void TekenVorm()
        {
            Console.ForegroundColor = this.Kleur;
            for (int i = 0; i < Lengte; i++)
            {
                for (int j = 0; j < Breedte; j++)
                {
                    Console.SetCursorPosition(X + i, Y + j);
                    Console.Write("*");
                }
            }
        }
    }
}
