using System;
using System.Collections.Generic;
using System.Text;

namespace SorteerAlgoritmen
{
    class SelectionSort
    {

        public int[] Sort(int[] lijst)
        {
            int min_index = 0;

            for (int i = 0; i < lijst.Length-1; i++)
            {
                min_index = i;

                for (int j = i+1; j < lijst.Length; j++)
                {
                    if (lijst[j] < lijst[min_index] ) 
                    {
                        min_index = j;
                    }
                }
                if (min_index != i)
                {
                    int temp = lijst[i];
                    lijst[i] = lijst[min_index];
                    lijst[min_index] = temp;
                }
            
            }
            return lijst;
        }

    }
}
