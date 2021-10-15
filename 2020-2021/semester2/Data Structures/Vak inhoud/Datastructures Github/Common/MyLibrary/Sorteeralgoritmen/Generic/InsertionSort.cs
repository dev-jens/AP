using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Sorteeralgoritmen.Generic
{
    public class InsertionSort
    {
        public void Sort<T>(T[] list) where T:IComparable
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

        /// <summary>
        /// Sort the list with a specific Comparer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="comparer"></param>
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
