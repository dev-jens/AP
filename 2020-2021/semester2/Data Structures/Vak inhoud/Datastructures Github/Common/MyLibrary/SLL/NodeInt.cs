using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.SLL
{
    public class NodeInt : NodeIntBase
    {
        public NodeInt(int value) : base(value) { }

        public NodeInt Next { get; internal set; }

        public override string ToString()
        {
            return base.ToString() + (Next != null? "-" + Next.ToString():"");
        }
    }
}
