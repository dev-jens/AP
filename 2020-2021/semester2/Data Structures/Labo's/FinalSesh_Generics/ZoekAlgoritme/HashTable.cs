using FinalSesh_Generics.SLL_Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSesh_Generics.ZoekAlgoritme
{
    class HashTable<T> where T: IComparable<T>
    {
        Node<T>[] array;
        public HashTable(int size)
        {
            array = new Node<T>[size];
        }

        public void AddItem(T text) 
        {
            var idx = CalcIndex(text);
            var node = array[idx];
            if (node == null)
                array[idx] = new Node<T>(text);
            else
            {
                while (node != null)
                {
                    if (node.Value.CompareTo(text) == 0)
                        return;
                    else if (node.Next != null)
                        node = node.Next;
                    else
                    {
                        node.Next = new Node<T>(text);
                        return;
                    }
                }
            }
        }

        public int FindItem(T text)
        {
            var idx = CalcIndex(text);
            var node = array[idx];
            while (node != null)
            {
                if (node.Value.CompareTo(text) == 0)
                    return idx;
                node = node.Next;
            }
            return -1;
        }

        public Node<T>[] Array
        {
            get
            {
                Node<T>[] copy = new Node<T>[array.Length];
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

