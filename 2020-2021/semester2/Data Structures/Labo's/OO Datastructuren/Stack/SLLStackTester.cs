using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Datastructuren.Stack
{
    class SLLStackTester
    {
        public static void Start()
        {
            bool loop = true;
            SLLStack stack = new SLLStack();
            string msg = "";
            do
            {
                Console.WriteLine(msg);
                Console.WriteLine("1: Push , 2: Pop 3: Quit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("welk getal?");
                        int value = int.Parse(Console.ReadLine());
                        stack.Push(value);
                        msg += Convert.ToString(value) + "--";

                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("popped = " + stack.Pop());
                        break;
                    case 3:
                        loop = false;
                        break;
                    default:
                        break;
                }


            } while (loop);


        }
    
    }
}
