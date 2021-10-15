using System;
using FinalSesh_Generics.SLL_Generic;
using System.Collections.Generic;
using System.Text;

namespace FinalSesh_Generics.ZoekAlgoritme
{
    class HashTable2<T> where T: IComparable<T>
    {
        SLL_Generic.List<T>[] array;
        public HashTable2(int size)
        {
            array = new SLL_Generic.List<T>[size];
        }

        public void AddItem(T text)
        {
            var idx = CalcIndex(text);
            if (array[idx] != null)
            {
                if (array[idx].FindNode(text) != null)
                    return;
            }
            else
                array[idx] = new SLL_Generic.List<T>();

            array[idx].AddLast(text);
        }

        public int FindItem(T text)
        {
            var idx = CalcIndex(text);
            if (array[idx] == null)
                return -1;
            if (array[idx].FindNode(text) != null)
                return idx;

            return -1;
        }

        public SLL_Generic.List<T>[] Array
        {
            get
            {
                SLL_Generic.List<T>[] copy = new SLL_Generic.List<T>[array.Length];
                array.CopyTo(copy, 0);
                return copy;
            }
        }
        private int CalcIndex(T text)
        {
            return Math.Abs(text.GetHashCode()) % array.Length;
        }
    }
}

