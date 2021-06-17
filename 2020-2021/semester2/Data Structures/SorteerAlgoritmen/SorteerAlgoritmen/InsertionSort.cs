using System;
using System.Collections.Generic;
using System.Text;

namespace SorteerAlgoritmen
{
    class InsertionSort
    {

        public int[] Sort(int[] lijst)
        {
            for (int i = 1; i < lijst.Length ; i++)
            {
                int key = lijst[i];
                int j = i - 1; // j is altijd het linker item van i

                // linker items is kleiner als het rechter dus swap, deze loop zal blijven gaan tot het linker item
                while (j>= 0 && key < lijst[j]) 
                {
                    int temp = lijst[j];
                    lijst[j] = lijst[j+1];
                    lijst[j+1] = temp;
                    j--;
                }
            }

            return lijst;
        }

    }
}
