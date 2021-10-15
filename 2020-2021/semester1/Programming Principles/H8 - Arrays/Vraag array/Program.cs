using System;

namespace Vraag_array
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
       

        static void Main(string[] args)
        {
            string[] vragen = { "age", "year", "5+1", "postcode" };
            int[] antwoorden = new int[vragen.Length];

            for (int i = 0; i < vragen.Length; i++)
            {
                Console.Write(vragen[i]);
                antwoorden[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vragen.Length; i++)
            {
                Console.WriteLine($"{vragen[i]} : {antwoorden[i]}");
            }


        }
    }
}
