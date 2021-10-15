using System;
using System.Collections.Generic;
using System.Text;

namespace Ziekenhuis
{
    class VerzekerdePatient : Patient
    {
        public override double Berekenkost()
        {
            double perc = base.Berekenkost() * 0.1;


            return base.Berekenkost() - perc;
        }

    }
}
