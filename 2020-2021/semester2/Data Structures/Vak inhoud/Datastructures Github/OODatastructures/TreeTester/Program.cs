using MyLibrary.Sorteeralgoritmen;
using MyLibrary.Tree.BST;
using MyLibrary.Tree.BST.Generic;
using System;

namespace TreeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, here comes a nice Binary sorted tree !");
            Console.WriteLine();
            Console.WriteLine("Hoeveel getallen wil je aan de boom toevoegen ?");
            int amount = 0;
            int.TryParse(Console.ReadLine(), out amount);
            bool loop = true;
            //Create new Tree
            var t = new Tree<int>();
            //Fill it with some random numbers
            var rnd = new RandomGenerator(amount, 0, amount * 5, true).GenerateNumbers();
            for (int i = 0; i < rnd.Length; i++)
            {
                t.Insert(rnd[i]);
            }

            do
            {
                Console.CursorVisible = false;
                Console.Clear();
                //Pretty print the tree with the BinaryTreePrinter
                t.Root.Print();

                Console.WriteLine();
                Console.CursorVisible = true;
                //What next ?
                Console.WriteLine("Commando: Add, Remove, New Tree of Quit ? (bv. A[getal]  R[getal] N[Aantal] Q1");
                int value;
                var cmd = Console.ReadLine();
                if (int.TryParse(cmd.Substring(1), out value))
                {
                    switch (cmd[0])
                    {
                        case 'A':
                            t.Insert(value);
                            break;
                        case 'R':
                            t.Remove(value);
                            break;
                        case 'N':
                            t.Clear();
                            var rnd2 = new RandomGenerator(value, 0, value * 5, true).GenerateNumbers();
                            for (int i = 0; i < rnd2.Length; i++)
                            {
                                t.Insert(rnd2[i]);
                            }
                            break;
                        default:
                            loop = false;
                            break;
                    }
                }
                else
                    Console.WriteLine("Gelieve een geldig getal in te geven");
            }
            while (loop);
        }
    }
}
