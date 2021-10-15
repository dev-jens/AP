using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Generic
{
    class CompareByHeight : Comparer<Pokemon>
    {
        public override int Compare(Pokemon x, Pokemon y)
        {
            // de waarde zijn omgedraaid zodat het sorteer algoritme van groot naar klein zal sorteren

            if (x.Height > y.Height)
                return -1;
            if (x.Height < y.Height)
                return 1;
            return 0;

            

            
        }
    }
}
