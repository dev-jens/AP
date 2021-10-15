using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Sorteeralgoritmen
{
    public class QuickSort
    {
        public void Sort(int[] list)
        {
            Sort(list, 0, list.Length - 1);
        }

        private void Sort(int[] list, int lowerIndex, int higherIndex)
        {
            var i = lowerIndex;
            var j = higherIndex;

            int pivot = list[lowerIndex + (higherIndex - lowerIndex) / 2];

            while (i <= j)
            {
                while (list[i] < pivot)
                    i++;
                while (list[j] > pivot)
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
