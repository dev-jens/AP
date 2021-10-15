using System;
using System.Collections.Generic;
using System.Text;

namespace SorteerAlgo.Algoritme_klassen
{
    class BubbleSort
    {
        public void Sort(int[] lijst)
        {
           
            for (int i = 1; i <= lijst.Length-1; i++)
            {
                bool hasswapped = false;

                for (int j = 0; j < lijst.Length-i ; j++)
                {
                    if (lijst[j] > lijst[j+1])
                    {
                        int temp = lijst[j];
                        lijst[j] = lijst[j + 1];
                        lijst[j + 1] = temp;
                        hasswapped = true;
                    }
                }
                if (!hasswapped)
                {
                    return;
                }

            }
        }
    }
}
