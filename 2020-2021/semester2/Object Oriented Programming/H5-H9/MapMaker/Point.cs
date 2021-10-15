using System;
using System.Collections.Generic;
using System.Text;

namespace MapMaker
{
    class Point
    {
        
            private int x;
            private int y;

            public Point(int inx, int iny)
            {
                x = inx;
                y = iny;
            }

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }
        
    }
}
