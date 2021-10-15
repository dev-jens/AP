using System;
using System.Collections.Generic;
using FinalSesh_Generics.SLL_Generic;
using System.Text;

namespace FinalSesh_Generics.SorteerAlgoritme
{
    class InsertionSort
    {
        public void Sort<T>(T[] list) where T : IComparable
        {
            for (int i = 1; i < list.Length; i++)
            {
                T current = list[i];
                int newIndex = i;
                while (newIndex > 0)
                {
                    if (current.CompareTo(list[newIndex - 1]) < 0)
                    {
                        list[newIndex] = list[newIndex - 1];
                        newIndex--;
                    }
                    else
                        break;
                }
                list[newIndex] = current;
            }
        }

        public void Sort<T>(T[] list, IComparer<T> comparer)
        {
            for (int i = 1; i < list.Length; i++)
            {
                T current = list[i];
                int newIndex = i;
                while (newIndex > 0)
                {
                    if (comparer.Compare(current, list[newIndex - 1]) < 0)
                    {
                        list[newIndex] = list[newIndex - 1];
                        newIndex--;
                    }
                    else
                        break;
                }
                list[newIndex] = current;
            }
        }

        

    }
}
