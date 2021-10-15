using System;

namespace Selection_sort
{
    class Program
    {
        static void PrintArrayInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        } /// print array

        static void PrintArrayString(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        } /// print array

        static void Main(string[] args)
        {
            // intelegent sort int
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8 };
            SelectionSortInt(list);
            PrintArrayInt(list);
            Console.WriteLine();
            string[] list_BigTechCEO = { "baeten", "zuckerburg", "Gates", "Boyens", "Van der Avoirt" };
            SelectionSortString(list_BigTechCEO);
            PrintArrayString(list_BigTechCEO);
        }

        public static void SelectionSortInt(int[] list)
        {
            int minimumIndex = 0;
            bool HasSwapped = false;

            for (int i = 0; i < list.Length - 1; i++)
            {
                HasSwapped = false;
                minimumIndex = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[minimumIndex])
                        minimumIndex = j;
                }
                if (minimumIndex != i)
                {
                    var temp = list[i];
                    list[i] = list[minimumIndex];
                    list[minimumIndex] = temp;
                    HasSwapped = true;
                }
               
            }
            if (!HasSwapped)
            {
                Console.WriteLine("is gestorteerd");
            }
        }

        public static void SelectionSortString(string[] list)
        {
            int minimumIndex = 0;

            for (int i = 0; i < list.Length - 1; i++)
            {
                minimumIndex = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (String.Compare(list[j], list[minimumIndex]) < 0)
                        minimumIndex = j;
                }
                if (minimumIndex != i)
                {
                    var temp = list[i];
                    list[i] = list[minimumIndex];
                    list[minimumIndex] = temp;
                }
            }
        }
    }
}
