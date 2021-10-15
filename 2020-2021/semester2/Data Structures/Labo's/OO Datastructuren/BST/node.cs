using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Datastructuren.BST
{
    class node
    {

        public node(int value)
        {
            Value = value;
        }


        public int Value { get; set; }
        public node Left { get; set; }
        public node Right { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
