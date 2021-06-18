using System;

namespace Insertion_Sort
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        } /// print array

        static void Main(string[] args)
        {
            int[] list = { 3, 4, 2};
            InsertionSort(list);
            PrintArray(list);

         

        }

        public static void InsertionSort(int[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                int current = list[i];
                int newIndex = i;
                while (newIndex > 0 && list[newIndex - 1] > current) // verbeterde versie mindercode 
                {
                    list[newIndex] = list[newIndex - 1];
                    newIndex--;
                }
                list[newIndex] = current;
            }
        }

        public static void Sort(Auto[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                var current = list[i];       //type 'Auto' kan ook ipv. 'var', maar dit bespaart werk als ik nadien bv. ook een sorteer 'Persoon', 'Fruit',... versie wil maken
                int newIndex = i;
                while (newIndex > 0)
                {
                    if (current.AantalKm < list[newIndex - 1].AantalKm)  //Crusiaal verschil de bovenste versie, we vergelijken hier de km stand om Auto's te kunnen rangschikken, maar.. is dit de beste manier ????
                    {
                        list[newIndex] = list[newIndex - 1];
                        newIndex--;
                    }
                    else
                        break;
                }
                list[newIndex] = current;
            }
        }
        static void insertionSortRecursive(int[] arr,
                                       int n)
        {
            // Base case
            if (n <= 1)
                return;

            // Sort first n-1 elements
            insertionSortRecursive(arr, n - 1);

            // Insert last element at
            // its correct position
            // in sorted array.
            int last = arr[n - 1];
            int j = n - 2;

            /* Move elements of arr[0..i-1],
            that are greater than key, to
            one position ahead of their
            current position */
            while (j >= 0 && arr[j] > last)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = last;
        }







    }
}
