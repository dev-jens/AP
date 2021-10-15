using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OO_Datastructuren.BST
{
    class BinaryTreeTester
    {
        public static void Start()
        {
            Console.WriteLine("Hello World, here comes a nice Binary sorted tree !");
            Console.WriteLine();
            Console.WriteLine("Hoeveel getallen wil je aan de boom toevoegen ?");
            int amount = 0;
            int.TryParse(Console.ReadLine(), out amount);
            bool loop = true;
            //Create new Tree
            var t = new Tree();
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
                BinaryTreePrinter.BTreePrinter.Print(t.Root);

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
    public class RandomGenerator
    {
        private readonly int amount;
        private readonly int min;
        private readonly int max;
        private readonly bool unique;

        public RandomGenerator(int Amount = 10, int Min = 0, int Max = 100, bool Unique = false)
        {
            amount = Amount;
            min = Min == 0 ? 1 : Min;
            max = Max;
            unique = Unique;
        }

        public int[] GenerateNumbers()
        {
            var list = new int[amount];
            var rnd = new Random();
            int i = 0;
            int temp = 0;

            if (unique)
            {
                if (amount > max - min)
                    throw new Exception($"it is not possible to generate {amount} unique numbers between {min} and {max}");
            }

            while (i < amount)
            {
                do
                {
                    temp = rnd.Next(min, max);
                }
                while (unique && list.Contains(temp));

                list[i] = temp;
                i++;
            }
            return list;
        }
    }






}
