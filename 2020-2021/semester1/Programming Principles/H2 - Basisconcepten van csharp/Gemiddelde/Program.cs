using System;
using System.Runtime.InteropServices;

namespace Gemiddelde
{
    class Program
    {
        static void Main(string[] args)
        {
            int september = 270;
            int oktober = 217;
            int november = 235;

            double gemiddelde = (september + oktober + november) / 3.0;

            Console.WriteLine($"gemiddelde uur slaap is {gemiddelde}");


        }
    }
}
