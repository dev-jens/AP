using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSesh_Generics.SorteerAlgoritme
{
    class MergeSort
    {
        public T[] Sort<T>(T[] list) where T: IComparable<T>
        {
            if (list.Length <= 1)
                return list;

            var first = new T[list.Length / 2];
            var second = new T[list.Length - first.Length];
            Array.Copy(list, 0, first, 0, first.Length);
            Array.Copy(list, first.Length, second, 0, second.Length);

            Sort(first);
            Sort(second);

            int firstIndex = 0;
            int secondIndex = 0;
            var index = 0;
            while (firstIndex < first.Length || secondIndex < second.Length)
            {
                if (secondIndex == second.Length || (firstIndex < first.Length && first[firstIndex].CompareTo(second[secondIndex]) <= 0))
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
