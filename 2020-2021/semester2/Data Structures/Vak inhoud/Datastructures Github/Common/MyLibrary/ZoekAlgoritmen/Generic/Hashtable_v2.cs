using MyLibrary.SLL.Generic;
using System;

namespace MyLibrary.ZoekAlgoritmen.Generic
{
    public class Hashtable_v2<T> where T:IComparable<T>
    {
        Node<T>[] array;
        public Hashtable_v2(int size)
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
