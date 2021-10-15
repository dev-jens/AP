using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.DLL
{
    public class NodeInt : SLL.NodeIntBase
    {
        private NodeInt next, prev;

        public NodeInt(int value) : base(value) { }

        /// <summary>
        /// While setting the Next, we always assure that that node points also to this node
        /// </summary>
        public NodeInt Next
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

        /// <summary>
        /// While setting the Previous, we always assure that that node points also to this node
        /// </summary>
        public NodeInt Prev
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
