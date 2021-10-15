using MyLibrary.SLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.ZoekAlgoritmen
{
    public class LineairSearch
    {
        /// <summary>
        /// Find the specified value in the specified array
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Find(int[] list, int value)
        {
            if (list == null || list.Length == 0)
                throw new ArgumentException("the list cannot be empty");

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == value)
                    return i;
            }
            return -1;
        }

        public int Find(string[] list, string value)
        {
            if (list == null || list.Length == 0)
                throw new ArgumentException("the list cannot be empty");

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == value)
                    return i;
            }
            return -1;
        }


        public NodeInt Find (ListInt list, int value)
        {
            if (list == null)
                throw new ArgumentException("the list cannot be empty");

            NodeInt start = list.First;
            while (start != null)
            {
                if (start.Value == value)
                    break;                  //Why not Mr.Dams ...?

                start = start.Next;   
            }
            return start;                   //return the Node or NULL if not found
        }
    }
}
