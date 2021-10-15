using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Datastructuren.SLL
{
    class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }


        public Node(int value)
        {
            this.Value = value;
        }

     
    }
}
