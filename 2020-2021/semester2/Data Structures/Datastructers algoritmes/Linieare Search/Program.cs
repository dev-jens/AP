using System;

namespace Linieare_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //recursief
        static int recSearch(int[] arr, int l, int r, int x)
        {
            if (r < l)
                return -1;
            if (arr[l] == x)
                return l;
            if (arr[r] == x)
                return r;
            return recSearch(arr, l + 1, r - 1, x);
        }
    }
}
