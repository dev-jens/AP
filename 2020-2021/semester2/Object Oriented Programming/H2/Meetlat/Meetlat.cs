using System;
using System.Collections.Generic;
using System.Text;

namespace Meetlat
{
    class Meetlat
    {
        private int beginlengte;
        public int  BeginLengte
        {
            set { beginlengte = value; }
        }
        public int lengteInM
        {
            get { return beginlengte; }
        }


    }
}
