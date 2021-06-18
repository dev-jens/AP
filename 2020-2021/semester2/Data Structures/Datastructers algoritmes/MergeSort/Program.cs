using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] MergeSort(int[] list)
        {
            if (list.Length <= 1)
                return list;

            var first = new int[list.Length / 2];
            var second = new int[list.Length - first.Length];
            Array.Copy(list, 0, first, 0, first.Length);
            Array.Copy(list, first.Length, second, 0, second.Length);

            MergeSort(first);
            MergeSort(second);

            int firstIndex = 0, secondIndex = 0;
            int index = 0;
            while (firstIndex < first.Length || secondIndex < second.Length)
            {
                if (secondIndex == second.Length || (firstIndex < first.Length && first[firstIndex] <= second[secondIndex]))
                {
                    list[index++] = first[firstIndex++];
                }
                else
                {
                    list[index++] = second[secondIndex++];
                }
            }
            return list;
        }
    }
}
