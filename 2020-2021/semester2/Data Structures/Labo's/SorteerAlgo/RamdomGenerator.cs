using System;
using System.Collections.Generic;
using System.Text;

namespace SorteerAlgo
{
    class RamdomGenerator
    {
        private Random r = new Random();

        public int[] Generate(int lenght, int min, int max)
        {
            int[] array = new int[lenght];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(min,max+1);

            }
            return array;

        }
    }
}
