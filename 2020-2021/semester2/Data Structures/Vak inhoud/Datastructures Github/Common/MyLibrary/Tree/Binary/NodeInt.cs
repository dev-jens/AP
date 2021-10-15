using MyLibrary.SLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Tree.Binary
{
    public class NodeInt : NodeIntBase
    {
        public NodeInt(int value) : base(value)
        {
        }

        public NodeInt Left { get; set; }
        public NodeInt Right { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
