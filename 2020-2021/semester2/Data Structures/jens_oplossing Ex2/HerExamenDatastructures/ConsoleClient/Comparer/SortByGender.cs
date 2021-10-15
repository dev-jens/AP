using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Comparer
{
    class SortByGender : Comparer<Person>
    {
        public override int Compare(Person x, Person y)
        {
            if (x.Gender == Gender.Female && y.Gender == Gender.Male)
                return -1;
            else if (y.Gender == Gender.Female && x.Gender == Gender.Male)
                return 1;
            return 0;
        }
    }
}
