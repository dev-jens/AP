using System;

namespace arrayVieuwer
{
    class Program
    {
        static void VisualiseerArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]},\t");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] array = { 15, 6, 9 };
            int[] array2 = { 0, 1, 2, 3, 4, 5, 6 };
            VisualiseerArray(array);
            VisualiseerArray(array2);

        }
    }
}
