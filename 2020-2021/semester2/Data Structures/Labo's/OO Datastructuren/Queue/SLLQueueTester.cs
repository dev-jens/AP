using System;
using System.Collections.Generic;
using System.Text;
using OO_Datastructuren.SLL;

namespace OO_Datastructuren.Queue
{
    class SLLQueueTester
    {
        public static void Start()
        {
            bool loop = true;
            SLLQueue queue = new SLLQueue();
            string msg = "";
            do
            {
                Console.WriteLine(msg);
                Console.WriteLine("1: Enqueue , 2: Dequeue 3: Quit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("welk getal?");
                        int value = int.Parse(Console.ReadLine());
                        queue.EnQueue(value);
                        msg += Convert.ToString(value) + "--";

                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Dequeued = " + queue.DeQueue());
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
