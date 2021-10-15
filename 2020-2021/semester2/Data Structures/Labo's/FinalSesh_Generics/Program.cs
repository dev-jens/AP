using FinalSesh_Generics.SorteerAlgoritme;
using System;

namespace FinalSesh_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 2, 5, 67, 87, 53, 65, 7, 83, 98, 93 };
            MergeSort MS = new MergeSort();
            SelectionSort SS = new SelectionSort();
            SS.Sort<int>(list);

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
