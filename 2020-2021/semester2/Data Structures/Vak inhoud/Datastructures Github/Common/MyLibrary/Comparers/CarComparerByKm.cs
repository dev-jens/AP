using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Comparers
{
    public class CarComparerByKm : IComparer<Auto>
    {
        public int Compare(Auto x, Auto y)
        {
            if (x == null || y == null)
            {
                if (x == null && y == null)
                    return 0;
                if (x == null)
                    return -1;
                return 1;
            }
            if (x.AantalKm < y.AantalKm)
                return -1;
            if (x.AantalKm > y.AantalKm)
                return 1;
            
            return 0;
        }
    }
}
