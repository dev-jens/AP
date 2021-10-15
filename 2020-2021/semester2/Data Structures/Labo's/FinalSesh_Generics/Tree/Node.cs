using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSesh_Generics.Tree
{
    class Node<T>
    {

        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }

    }
}
