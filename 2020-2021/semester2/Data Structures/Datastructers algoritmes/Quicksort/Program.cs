using System;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private void QuickSort(int[] list, int lowerIndex, int higherIndex)
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
                QuickSort(list, lowerIndex, j);
            if (i < higherIndex)
                QuickSort(list, i, higherIndex);
        }
    }
}
