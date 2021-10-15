using System;
using System.Collections.Generic;
using System.Text;

namespace Hammertje_Tik
{

    enum Richting {Links,Rechts,Boven,Benenden }
    interface IBeweegbaar
    {
        void beweeg(Richting richting);
    }
}
