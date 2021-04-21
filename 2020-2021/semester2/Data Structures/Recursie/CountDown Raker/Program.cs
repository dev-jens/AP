using System;

namespace CountDown_Raker
{
    class Program
    {
       

        static void Main(string[] args)
        {
            void CountDown(int number)
            {
                // Exit Condition 
                if (number <= 0)
                {
                    Console.WriteLine("Take off ! ");
                    return;
                }
                Console.Write($"{number}.. ");
                CountDown(number - 1);
                
            }
            Console.WriteLine("fix input groter dan 0");
            int input = int.Parse(Console.ReadLine());
            CountDown(input);

            
        }
    }
}
