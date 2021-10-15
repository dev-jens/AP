using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.SLL.Generic
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public Node<T> Next { get; internal set; }
        public T Value { get; internal set; }

        public override string ToString()
        {
            return base.ToString() + (Next != null ? "-" + Next.ToString() : "");
        }
    }
}
