using System;
using System.Collections.Generic;
using System.Text;

namespace ZoekAlgoritmes.hashTable
{
    class HashTable
    {
        string[] array;

        public HashTable(int size)
        {
            array = new string[size];
        }

        public void AddItem(string text)
        {
            var idx = CalcIndex(text);
            if (array[idx] != null && array[idx] != text)
                throw new Exception("Sorry, the item cannot be added to the Table");

            array[idx] = text;
        }

        public int FindItem(string text)
        {
            var idx = CalcIndex(text);
            if (array[idx] == text)
                return idx;

            return -1;
        }

        public string[] Array
        {
            get
            {
                string[] copy = new string[array.Length];
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
