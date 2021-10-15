using System;
using System.Collections.Generic;
using System.Text;

namespace SorteerAlgo.Algoritme_klassen
{
    class InsertionSort
    {
        public void Sort(int[] lijst)
        {
            for (int i = 1; i < lijst.Length-1; i++)
            {
                int curr = lijst[i];
                int j = i - 1;
                while (j >= 0 && lijst[j] > curr)
                {
                    lijst[j + 1] = lijst[j];
                    j--; 
                }
                lijst[j + 1] = curr;
            }
        }

    }
}
