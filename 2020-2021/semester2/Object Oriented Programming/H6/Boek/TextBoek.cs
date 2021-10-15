using System;
using System.Collections.Generic;
using System.Text;

namespace Boek
{
    class TextBoek : Boek
    {
        public int GradeLevel { get; set; }

        public override double Prijs 
        {
            get { return base.Prijs; }

            set 
            { 
                if(value > 20 && value < 80)
                    base.Prijs = value; 
            } 
        
        }

    }
}
