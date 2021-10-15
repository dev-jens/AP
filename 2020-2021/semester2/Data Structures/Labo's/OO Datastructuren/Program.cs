using OO_Datastructuren.DLL;
using OO_Datastructuren.SLL;
using OO_Datastructuren.Queue;
using OO_Datastructuren.Stack;
using System;
using OO_Datastructuren.SLLBubbleSort;
using OO_Datastructuren.BST;

namespace OO_Datastructuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke OO Datastructuur wilt u testen?");
            Console.WriteLine();
            Console.WriteLine("A: SLL Tester ,B:  DLL Tester,C: SLL StackTester,D: SLL QueueTester,E: SLL BubbleSortTester,F: binary tree printer");
            string input = Console.ReadLine().ToUpper();

            switch (input)
            {
                case "A":
                    SLLTester.Start();
                    break;
                case "B":
                    DLLTester.Start();
                    break;
                case "C":
                    SLLStackTester.Start();
                    break;
                case "D":
                    SLLQueueTester.Start();
                    break;
                case "E":
                    SLLBubbleSortTester.Start();
                    break;
                case "F":
                    BinaryTreeTester.Start();
                    break;
                default:
                    break;
            }
        }
    }
}
