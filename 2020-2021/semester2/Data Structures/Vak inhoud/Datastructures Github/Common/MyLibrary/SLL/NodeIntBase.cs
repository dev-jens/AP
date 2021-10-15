using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.SLL
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
