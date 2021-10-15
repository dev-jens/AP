using System;
using System.Collections.Generic;
using System.Text;

namespace ZoekAlgoritmes.hashTable
{
    class HashTableV3
    {

        ListString[] array;
        public HashTableV3(int size)
        {
            array = new ListString[size];
        }

        public void AddItem(string text)
        {
            var idx = CalcIndex(text);
            if (array[idx] != null)
            {
                if (array[idx].FindNode(text) != null)
                    return;
            }
            else
                array[idx] = new ListString();

            array[idx].AddLast(text);
        }

        public int FindItem(string text)
        {
            var idx = CalcIndex(text);
            if (array[idx] == null)
                return -1;
            if (array[idx].FindNode(text) != null)
                return idx;

            return -1;
        }




        public ListString[] Array
        {
            get
            {
                ListString[] copy = new ListString[array.Length];
                array.CopyTo(copy, 0);
                return copy;
            }
        }
        private int CalcIndex(string text)
        {
            return Math.Abs(text.GetHashCode()) % array.Length;
        }


    }
}
