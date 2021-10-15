using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSesh_Generics.ZoekAlgoritme
{
    class BinarySearch
    {
        public int Find<T>(T[] list, T value) where T : IComparable<T>
        {
            if (list == null || list.Length == 0) throw new ArgumentException("The list cannot be empty");

            return Find(list, value, 0, list.Length - 1);
        }

        private int Find<T>(T[] list, T value, int minIndex, int maxIndex) where T : IComparable<T>
        {
            if (maxIndex < minIndex) return -1;         //base case: value was not found in the list

            var middleIdx = minIndex + (maxIndex - minIndex) / 2;   //locate the middle of the list

            if (list[middleIdx].CompareTo(value) > 0)
                return Find(list, value, minIndex, middleIdx - 1);  // search again in the left part
            else if (list[middleIdx].CompareTo(value) < 0)
                return Find(list, value, middleIdx + 1, maxIndex);  // search again in the right part

            return middleIdx;       // value found (return its index) !!!!
        }



    }
}
