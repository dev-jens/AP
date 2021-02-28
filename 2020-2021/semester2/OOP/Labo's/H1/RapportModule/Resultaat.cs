using System;
using System.Collections.Generic;
using System.Text;

namespace RapportModule
{
    class Resultaat
    {
        public double BehaaldCijfer { get; set; }
        public void PrintGraad()
        {
            if (BehaaldCijfer < 50)
                Console.WriteLine("niet geslaagd");
            else if(BehaaldCijfer <= 68)
                Console.WriteLine("Voldoende");
            else if (BehaaldCijfer <= 75)
                Console.WriteLine("onderscheiding");
            else if (BehaaldCijfer <= 85)
                Console.WriteLine("grote onderscheiding");
            else 
                Console.WriteLine("grootste onderscheiding");
        }

    }
}
