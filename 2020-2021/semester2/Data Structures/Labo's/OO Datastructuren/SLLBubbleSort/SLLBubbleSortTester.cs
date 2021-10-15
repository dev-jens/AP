using System;
using System.Collections.Generic;
using System.Text;
using OO_Datastructuren.SLL;

namespace OO_Datastructuren.SLLBubbleSort
{
    class SLLBubbleSortTester
    {
        public static void Start() 
        {
            List list = new List();
            SLLBubbleSort sllBS = new SLLBubbleSort();
            bool loop = true;
            int lengte = 0;
            int teller = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1: create , 2: Print 3: Quit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("hoelang? ");
                        lengte = int.Parse(Console.ReadLine());
                        while (teller < lengte)
                        {
                            Console.WriteLine("fix getal ");
                            int value = int.Parse(Console.ReadLine());
                            list.AddLast(value);
                            teller++;
                        }
                        break;
                    case 2:
                        sllBS.Sort(list);
                        printList(list);
                        list.clear();

                        break;
                    case 3 :
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("oei oei niet goed somethin went ronk");
                        break;
                }
            } while (loop);


        }

        private static void printList(List list)
        {
            while (list.First != null)
            {
                if (list.First.Next == null)
                {
                    Console.Write("|" + list.First.Value + "|");
                    return;
                }
                else
                {
                    Console.Write("|" + list.First.Value + "|" + "--");
                    list.First = list.First.Next;
                }
             
            }
        }
    }
}
