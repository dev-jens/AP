using System;

namespace Array___methode_combo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 1, 2, 3 };
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"{ages[i]}, ");
            }

            static void DoubleArray(int[] v, int index)
            {
                for (int i = 0; i < index; i++)
                {
                    v[i] *= 2;
                }

            }

            DoubleArray(ages, 1);
            Console.WriteLine("");

            for (int j = 0; j < ages.Length; j++)
            {
                Console.Write($"{ages[j]}, ");
            }
        }
    }
}
