using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Datastructuren.DLL
{
    class Node
    {
        private Node next, prev;

        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; internal set; }

        /// <summary>
        /// While setting the Next, we always assure that that node points also to this node
        /// </summary>
        public Node Next
        {
            get
            {
                return next;
            }
            internal set
            {
                this.next = value;
                if (value != null && !ReferenceEquals(value.Prev, this))
                    value.Prev = this;
            }
        }

       
        public Node Prev
        {
            get
            {
                return prev;
            }
            internal set
            {
                prev = value;
                if (value != null && !ReferenceEquals(value.Next, this))
                    prev.Next = this;
            }
        }



        public override string ToString()
        {
            return Value.ToString();
        }

      
    }
}
