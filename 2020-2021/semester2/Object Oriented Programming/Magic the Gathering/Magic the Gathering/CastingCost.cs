using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_the_Gathering
{
    class CastingCost
    {
        public Manatype ColoredTypeNeeded { get; private set; }
        public int AmoundColoredTypeNeeded { get; private set; }
        public int AMoundUnColoredTypeNeeded { get;  set; }

        public CastingCost(Manatype coloredTypeNeeded, int amountColoredTypeNeeded, int amountUncoloredTypeNeeded)
        {
            ColoredTypeNeeded = coloredTypeNeeded;
            AmoundColoredTypeNeeded = amountColoredTypeNeeded;
            AMoundUnColoredTypeNeeded = amountUncoloredTypeNeeded;
        }
    }

}
