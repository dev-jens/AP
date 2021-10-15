using System;

namespace Euler_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            for (int i = 0; i < 1001; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    som += i;
                }    
            }

            Console.WriteLine(som);
        }
    }
}
