using System;
using System.Collections.Generic;
using System.Text;

namespace MapMaker
{
    abstract class MapObject
    {
        private Point location;
        private double price;
        private char drawChar;

        //Teken object in de console
        public abstract void Paint();
    }
}
