using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.ZoekAlgoritmen
{

    /// <summary>
    /// Basic Hashtable without linked list
    /// So 2 items with the same hash cannot be stored in this list.
    /// (An exception will be thrown)
    /// </summary>
    public class Hashable
    {
        string[] array;
        public void Hashtable(int size)
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
            get {
                string[] copy = new string[array.Length];
                array.CopyTo(copy,0);
                return copy;
            }
        }
        private int CalcIndex(string text)
        {
            return Math.Abs(text.GetHashCode()) % array.Length;
        }
    }
}
