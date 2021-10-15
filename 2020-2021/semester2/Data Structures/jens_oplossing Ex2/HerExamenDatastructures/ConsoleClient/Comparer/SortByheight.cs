using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Comparer
{
    class SortByheight : Comparer<Person>
    {
        public override int Compare(Person x, Person y)
        {
            if (x.Height > y.Height)
                return -1;
            if (x.Height < y.Height)
                return 1;
            return 0;

        }
    }
   
}
