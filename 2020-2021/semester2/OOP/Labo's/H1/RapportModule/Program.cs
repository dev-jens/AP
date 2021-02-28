using System;

namespace RapportModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Resultaat leerling1 = new Resultaat();
            leerling1.BehaaldCijfer = 65;
            leerling1.PrintGraad();
        }
    }
}
