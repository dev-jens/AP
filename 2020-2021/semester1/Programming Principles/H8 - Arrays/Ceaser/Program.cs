using System;

namespace Ceaser
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
<<<<<<< HEAD:2020-2021/semester1/Programming Principles/oefeningen voor Examen/theorie test/Program.cs
            int[] jens = ArrayOfMultiples(7,6);
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{jens[i]}, " );
            }
=======
            Console.WriteLine("Hello World!");
>>>>>>> 0ba5e6184cf3462dc0f9ba9dd50dc0f7740533a8:2020-2021/semester1/Programming Principles/H8 - Arrays/Ceaser/Program.cs
        }
    }
}
