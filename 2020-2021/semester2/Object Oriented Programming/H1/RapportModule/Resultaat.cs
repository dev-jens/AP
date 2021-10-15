using System;
using System.Collections.Generic;
using System.Text;

namespace RapportModule
{
    class Resultaat
    {
        public int Percentage { get; set; }

        public void PrintGraad()
        {
            if (Percentage < 50)
                Console.WriteLine("niet geslaagd");
            else if (Percentage <= 68)
                Console.WriteLine("voldoende");
            else if (Percentage <= 75)
                Console.WriteLine("onderscheiding");
            else if (Percentage <= 85)
                Console.WriteLine("grote onderscheiding");
            else
                Console.WriteLine("grootste onderscheiding");
        }


    }
}
