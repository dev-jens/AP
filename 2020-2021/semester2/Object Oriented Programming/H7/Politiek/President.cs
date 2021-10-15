using System;
using System.Collections.Generic;
using System.Text;

namespace Politiek
{
    class President : Minister
    {
        public int teller { get; private set; } = 4;

        public void Jaarverder()
        {
            teller--;
        }
    }
}
