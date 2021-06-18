using System;

namespace JumpSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 35, 34, 5435, 3453, 36 };
           
            Console.Write(arr[jumpSearch(arr, 35)]);
        }



        public static int jumpSearch(int[] arr, int x)
        {
            int n = arr.Length;

            // Finding block size to be jumped
            int step = (int)Math.Floor(Math.Sqrt(n));

            // Finding the block where element is
            // present (if it is present)
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            // Doing a linear search for x in block
            // beginning with prev.
            while (arr[prev] < x)
            {
                prev++;

                // If we reached next block or end of
                // array, element is not present.
                if (prev == Math.Min(step, n))
                    return -1;
            }

            // If element is found
            if (arr[prev] == x)
                return prev;

            return -1;
        }
    }
}
