using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Sorteeralgoritmen.Generic
{
    public class QuickSort
    {
        public void Sort<T>(T[] list) where T:IComparable<T>
        {
            Sort(list, 0, list.Length - 1);
        }

        private void Sort<T>(T[] list, int lowerIndex, int higherIndex) where T : IComparable<T>
        {
            var i = lowerIndex;
            var j = higherIndex;

            T pivot = list[lowerIndex + (higherIndex - lowerIndex) / 2];

            while (i <= j)
            {
                while (list[i].CompareTo(pivot) < 0)
                    i++;
                while (list[j].CompareTo(pivot) > 0)
                    j--;

                if (i <= j)
                {
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }
            if (lowerIndex < j)
                Sort(list, lowerIndex, j);
            if (i < higherIndex)
                Sort(list, i, higherIndex);
        }
    }
}
