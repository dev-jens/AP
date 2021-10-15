using System;
using System.Collections.Generic;
using System.Text;

namespace Hammertje_Tik
{
    class Vloot : Vorm ,IBeweegbaar
    {
        private List<Vliegtuig> vliegvloot = new List<Vliegtuig>();
        public Vloot(int xin , int yin , int aantal) : base(xin, yin)
        {
            for (int i = 0; i < aantal; i++)
            {
                vliegvloot.Add(new Vliegtuig(xin, yin + 5 * i));
            }
        }

        public void beweeg(Richting richting)
        {
            switch (richting)
            {
                case Richting.Links:
                    X--;
                    break;
                case Richting.Rechts:
                    X++;
                    break;
                case Richting.Boven:
                    Y--;
                    break;
                case Richting.Benenden:
                    Y++;    
                    break;
                default:
                    break;
            }
        }

        public override void TekenVorm()
        {
            foreach (var vliegtuig in vliegvloot)
            {
                vliegtuig.TekenVorm();
            }
        }
    }
}
