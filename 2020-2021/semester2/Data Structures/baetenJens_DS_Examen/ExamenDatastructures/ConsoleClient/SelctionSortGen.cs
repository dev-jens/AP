using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class SelctionSortGen
    {
        public void Sort<T>(T[] list) where T : IComparable
        {
            int minimumIndex = 0;

            for (int i = 0; i < list.Length - 1; i++)
            {
                minimumIndex = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j].CompareTo(list[minimumIndex]) < 0)
                        minimumIndex = j;
                }
                if (minimumIndex != i)
                {
                    var temp = list[i];
                    list[i] = list[minimumIndex];
                    list[minimumIndex] = temp;
                }
            }
        }
    } 
}
