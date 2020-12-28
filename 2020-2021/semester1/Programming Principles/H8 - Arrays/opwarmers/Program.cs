using System;

namespace opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayeru = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

            // inlezen van 20 getallen
            /*for (int i = 0; i < arrayeru.Length; i++)
            {
                Console.Write("geef een getal: ");
                arrayeru[i] = int.Parse(Console.ReadLine());
            }*/
            for (int i = arrayeru.Length -1 ; i > 0 ; i--)
            {
                Console.Write($"{arrayeru[i]} " );
            }
        }
    }
}
