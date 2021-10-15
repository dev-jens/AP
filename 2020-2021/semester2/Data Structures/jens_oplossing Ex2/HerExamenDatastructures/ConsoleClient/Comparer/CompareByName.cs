using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Comparer
{
    class CompareByName : Comparer<Person>
    {
        public override int Compare(Person x, Person y)
        {
            if (x.Name.CompareTo(y.Name) > 0)
                return 1;
            if (x.Name.CompareTo(y.Name) < 0)
                return -1;

            return 0;
        }

    }
}
