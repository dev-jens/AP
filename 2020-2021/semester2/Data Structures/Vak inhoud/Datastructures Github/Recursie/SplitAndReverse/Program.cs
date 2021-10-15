using MyLibrary;
using MyLibrary.Queue.Array;
using System;

namespace SplitAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een string en ik keer deze om!");
            var text = Console.ReadLine();
            Console.WriteLine($"Het omgekeerde van {text} is");
            var q = Split(text);
            while (!q.IsEmpty)
                Console.Write(q.Dequeue());

            Console.WriteLine();
        }

        static LineairQueueString Split(string text)
        {
            var queue = new LineairQueueString();
            Split(queue, text);
            return queue;
        }

        static void Split(LineairQueueString queue, string text)
        {

            queue.Enqueue(text.Substring(text.Length-1));
            if (text.Length == 1) return;

            Split(queue, text.Substring(0, text.Length - 1));
        }
    }
}
