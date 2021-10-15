using System;

namespace Smallest_and_second_Smallets_element_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 13, 1, 10, 34, 1 };
            print2Smallest(arr);
        }
        static void print2Smallest(int[] arr)
        {
            int first, second, arr_size = arr.Length;

            /* There should be atleast two elements */
            if (arr_size < 2)
            {
                Console.Write(" Invalid Input ");
                return;
            }

            first = second = int.MaxValue;

            for (int i = 0; i < arr_size; i++)
            {
                /* If current element is smaller than first
                then update both first and second */
                if (arr[i] < first)
                {
                    second = first;
                    first = arr[i];
                }

                /* If arr[i] is in between first and second
                then update second */
                else if (arr[i] < second && arr[i] != first)
                    second = arr[i];
            }
            if (second == int.MaxValue)
                Console.Write("There is no second" +
                                "smallest element");
            else
                Console.Write("The smallest element is " +
                                first + " and second Smallest" +
                                " element is " + second);
        }
    }
}
