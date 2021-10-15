using System;
using System.Collections.Generic;
using System.Text;

namespace SSL
{
    public abstract class NodeIntBase
    {
            public NodeIntBase(int value)
            {
                this.Value = value;
            }

            public int Value { get; set; }

            public override string ToString() => $"Node:{Value}";

        
    }
}
