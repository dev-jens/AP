using System;
using System.Collections.Generic;
using System.Text;

namespace ZoekAlgoritmes.BinarySearch
{
    class BinarySearch
    {
       
        public int Find(int[] list, int value)
        {
            if (list == null || list.Length == 0) throw new ArgumentException("The list cannot be empty");

            return Find(list, value, 0, list.Length - 1);
        }

        private int Find(int[] list, int value, int minIndex, int maxIndex)
        {
            if (maxIndex < minIndex) return -1;         //base case: value was not found in the list

            var middleIdx = minIndex + (maxIndex - minIndex) / 2;   //locate the middle of the list

            if (list[middleIdx] > value)
                return Find(list, value, minIndex, middleIdx - 1);  // search again in the left part
            else if (list[middleIdx] < value)
                return Find(list, value, middleIdx + 1, maxIndex);  // search again in the right part

            return middleIdx;       // value found (return its index) !!!!
        }
    }
}
