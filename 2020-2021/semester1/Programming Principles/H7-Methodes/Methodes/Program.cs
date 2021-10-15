using System;

namespace Methodes
{
    class Program
    {
        static int Kwadraat (int getal) 
        {
            int result = (int)Math.Pow(getal, 2);
            return result;
        } // kwadraat berkenen

        static int StraalBerekenaar(int diameter) 
        {
            int straal = diameter / 2;

            return straal;
             
        } // straal berekenaar geeft dieamter in

        static int GrootsteGetal(int getal1,int getal2)
        {
            int grootste;
            if (getal1 > getal2)
            {
                grootste = getal1;
            }
            else
            {
                grootste = getal2;
            }

            return grootste;
        } // geeft grootste getal van 2 terug

        static bool IsEven(int getal)
        {
            bool IsEvenGet = false;
            if (getal %2 == 0)
            {
                IsEvenGet = true;
            }

            return IsEvenGet;
        }


        static void Main(string[] args)
        {
            int input = 5;
            int input2 = 10;

            Console.WriteLine(Kwadraat(input));
            Console.WriteLine(StraalBerekenaar(input));
            Console.WriteLine(GrootsteGetal(input,input2));
            Console.WriteLine(IsEven(input));
        }
    }
}
