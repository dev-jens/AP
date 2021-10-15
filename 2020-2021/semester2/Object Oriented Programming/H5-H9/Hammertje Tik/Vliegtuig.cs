using System;
using System.Collections.Generic;
using System.Text;

namespace Hammertje_Tik
{
    class Vliegtuig : Vorm ,IBeweegbaar
    {
        private Rechthoek rect;
        private Lijn l1;
        private Lijn l2;
        public Vliegtuig(int xin , int yin) : base(xin, yin)
        {
            rect = new Rechthoek(xin + 3, yin, 2, 5);
            l1 = new Lijn(xin, yin + 2, 3);
            l2 = new Lijn(xin + 5, yin + 2, 3);
        }

        public void beweeg(Richting richting)
        {
            switch (richting)
            {
                case Richting.Links:
                    X--;
                    rect.X--;
                    l1.X--;
                    l2.X--;
                    break;
                case Richting.Rechts:
                    X++;
                    rect.X++;
                    l1.X++;
                    l2.X++;
                    break;
                case Richting.Boven:
                    Y--;
                    rect.Y--;
                    l1.Y--;
                    l2.Y--;
                    break;
                case Richting.Benenden:
                    Y++;
                    rect.Y++;
                    l1.Y++;
                    l2.Y++;
                    break;
                default:
                    break;
            }
        }

        public override void TekenVorm()
        {
            rect.TekenVorm();
            l1.TekenVorm();
            l2.TekenVorm();
        }
    }
}
