using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSesh_Generics.SLL_Generic
{
    class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }


        public Node(T value)
        {
            this.Value = value;
        }

    }
}
