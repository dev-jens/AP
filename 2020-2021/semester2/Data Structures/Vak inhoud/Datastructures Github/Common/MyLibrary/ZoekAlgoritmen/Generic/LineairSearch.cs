using MyLibrary.SLL.Generic;
using System;
using System.Linq;

namespace MyLibrary.ZoekAlgoritmen.Generic
{
    public class LineairSearch
    {
        /// <summary>
        /// Find the specified value in the specified array
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Find<T>(T[] list, T value) where T: IComparable<T>
        {
            if (list == null || list.Length == 0)
                throw new ArgumentException("the list cannot be empty");

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].CompareTo(value) == 0)
                    return i;
            }
            return -1;
        }


        public Node<T> Find<T>(List<T> list, T value) where T: IComparable<T>
        {
            if (list == null)
                throw new ArgumentException("the list cannot be empty");

            var start = list.First;
            while (start != null)
            {
                if (start.Value.CompareTo(value) == 0)
                    break;                  //Why not Mr.Dams ...?

                start = start.Next;
            }
            return start;                   //return the Node or NULL if not found
        }
    }
}
