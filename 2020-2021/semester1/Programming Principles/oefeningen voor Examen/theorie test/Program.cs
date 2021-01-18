using System;

namespace theorie_test
{
    class Program
    {
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] multiples = new int[length];

            for (int i = 0; i < length; i++)
            {
                multiples[i] = num *(i + 1);
            }
            return multiples;
        }


        static void Main(string[] args)
        {
            int[] jens = ArrayOfMultiples(7,6);
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{jens[i]}, " );
            }
        }
    }
}
