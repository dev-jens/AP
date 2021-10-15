using System;

namespace doordenker_PRO
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAstrixs = 5;

            for (int i = 0; i < maxAstrixs; i++)
            {
                for (int j = 0; j < maxAstrixs; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }  


        }        
    }
}
