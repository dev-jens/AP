using System;
using System.Collections.Generic;
using System.Text;

namespace Singly_linked_list.SSL
{
    class NodeInt
    {
        public NodeInt(int value)
        {
            this.Value = value;
        }

        public int Value { get; set; }

        public NodeInt Next { get; set; }
    }
}
