using MyLibrary.SLL;
using System;

namespace MyLibrary.ZoekAlgoritmen
{
    /// <summary>
    /// Hashtable with Nodes for solving collisions
    /// </summary>
    public class Hashtable_v2
    {
        NodeString[] array;
        public Hashtable_v2(int size)
        {
            array = new NodeString[size];
        }

        public void AddItem(string text)
        {
            var idx = CalcIndex(text);
            var node = array[idx];
            if (node == null)
                array[idx] = new NodeString(text);
            else
            {
                while (node != null)
                {
                    if (node.Value == text)
                        return;
                    else if (node.Next != null)
                        node = node.Next;
                    else
                    {
                        node.Next = new NodeString(text);
                        return;
                    }
                }
            }
        }

        public int FindItem(string text)
        {
            var idx = CalcIndex(text);
            var node = array[idx];
            while (node != null)
            {
                if (node.Value == text)
                    return idx;
                node = node.Next;
            }
            return -1;
        }

        public NodeString[] Array
        {
            get
            {
                NodeString[] copy = new NodeString[array.Length];
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
