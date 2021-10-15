using System;

namespace Find_the_repeating_and_the_missing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void printTwoElements(int[] arr, int size)
        {
            int i;
            Console.Write("The repeating element is ");

            for (i = 0; i < size; i++)
            {
                int abs_val = Math.Abs(arr[i]);
                if (arr[abs_val - 1] > 0)
                    arr[abs_val - 1] = -arr[abs_val - 1];
                else
                    Console.WriteLine(abs_val);
            }

            Console.Write("And the missing element is ");
            for (i = 0; i < size; i++)
            {
                if (arr[i] > 0)
                    Console.WriteLine(i + 1);
            }
        }
    }
}
