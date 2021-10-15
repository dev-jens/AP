using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Tree.Binary.Generic
{
    public class Node<T>
    {
        public Node(T value) 
        {
            Value = value;
        }

        public T Value { get; internal set; }

        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
