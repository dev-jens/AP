using System;

namespace methode_tester
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 7;

           int h = 8;
            Console.WriteLine(CMethod(g,h));
            string res = $"Jos is " + "{3 - 2}";
            Console.WriteLine(res);


            string tim, dams;
            tim = "tim";
            dams = "dams";
            Console.WriteLine(tim,dams);




        }
    
           static int CMethod(int g, int h)

            {

                g = h; h = g; return h;

            }
        }
    
}
