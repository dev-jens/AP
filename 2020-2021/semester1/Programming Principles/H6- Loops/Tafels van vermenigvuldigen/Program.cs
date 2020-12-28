using System;

namespace Tafels_van_vermenigvuldigen
{
    class Program
    {
        static void Main(string[] args)
        {
            int product;

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    product = i * j;
                    Console.WriteLine($"{i} X {j} = {product}");
                }
            }

            
        }
    }
}
