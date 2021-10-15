using System;
using System.Collections.Generic;
using System.Text;

namespace Boek
{
    class KoffieTafelBoek :Boek
    {

        public override double Prijs
        {
            get { return base.Prijs; }

            set
            {
                if (value >= 35 && value < 100)
                    base.Prijs = value;
            }

        }
    }
}
