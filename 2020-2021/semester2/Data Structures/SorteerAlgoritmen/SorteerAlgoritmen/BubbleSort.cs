using System;
using System.Collections.Generic;
using System.Text;

namespace SorteerAlgoritmen
{
    class BubbleSort
    {


        public int[] Sort(int[] ToSort)
        {
            for (int i = 1; i <= ToSort.Length; i++)
            {
                for (int j = 0; j < ToSort.Length - i; j++)
                {
                    if (ToSort[j] > ToSort[j+1])
                    {
                        int temp = ToSort[j]; 
                        ToSort[j] = ToSort[j + 1]; 
                        ToSort[j + 1] = temp;
                    }
                }
            }
            return ToSort;  
        }
    }
}
