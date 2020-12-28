using System;

namespace Grootste_methode
{
    class Program
    {
        static int GrootsteMethode(int getal1, int getal2, int getal3)
        {
            if (getal1 > getal2 && getal1 > getal3)
            {
                return getal1;
            }
            else if (getal2 > getal1 && getal2 > getal3)
            {
                return getal2;
            }

            return getal3;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(GrootsteMethode(2,4,7));
        }
    }
}
