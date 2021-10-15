using System;

namespace String_Omkeren
{
    class Program
    {
        static string Reverse(string zin)
        {

            if (zin.Length <= 1)
            {
                return zin;
            }


            return Reverse(zin.Substring(1)) + zin[0];
        }


        static void Main(string[] args)
        {
            Console.WriteLine("geef een zin in ");
            string zin = Console.ReadLine();

            Console.WriteLine(Reverse(zin));
        }
    }
}
