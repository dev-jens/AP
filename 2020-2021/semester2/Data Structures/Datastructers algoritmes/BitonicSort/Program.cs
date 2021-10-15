using System;

namespace BitonicSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void compAndSwap(int[] a, int i, int j, int dir)
        {
            int k;
            if ((a[i] > a[j]))
                k = 1;
            else
                k = 0;
            if (dir == k)
                Swap(ref a[i], ref a[j]);
        }

        /*It recursively sorts a bitonic sequence in ascending order, 
          if dir = 1, and in descending order otherwise (means dir=0). 
          The sequence to be sorted starts at index position low, 
          the parameter cnt is the number of elements to be sorted.*/
        public static void bitonicMerge(int[] a, int low, int cnt, int dir)
        {
            if (cnt > 1)
            {
                int k = cnt / 2;
                for (int i = low; i < low + k; i++)
                    compAndSwap(a, i, i + k, dir);
                bitonicMerge(a, low, k, dir);
                bitonicMerge(a, low + k, k, dir);
            }
        }

        /* This function first produces a bitonic sequence by recursively 
            sorting its two halves in opposite sorting orders, and then 
            calls bitonicMerge to make them in the same order */
        public static void bitonicSort(int[] a, int low, int cnt, int dir)
        {
            if (cnt > 1)
            {
                int k = cnt / 2;

                // sort in ascending order since dir here is 1 
                bitonicSort(a, low, k, 1);

                // sort in descending order since dir here is 0 
                bitonicSort(a, low + k, k, 0);

                // Will merge wole sequence in ascending order 
                // since dir=1. 
                bitonicMerge(a, low, cnt, dir);
            }
        }

        /* Caller of bitonicSort for sorting the entire array of 
           length N in ASCENDING order */
        public static void sort(int[] a, int N, int up)
        {
            bitonicSort(a, 0, N, up);
        }
    }
}
