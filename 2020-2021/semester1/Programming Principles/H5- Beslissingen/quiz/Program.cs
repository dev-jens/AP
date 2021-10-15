using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0 ; 
            //vraag1
            Console.WriteLine("wat is de power house of the cell?");
            Console.WriteLine("a = mitochondria");
            Console.WriteLine("b = u moeder");
            Console.WriteLine("c = jfk kennedy");
            string inputVraag1 = Console.ReadLine().ToLower();

            switch (inputVraag1)
            {
                case "a":
                    Console.WriteLine("correct +2 punten");
                    score+=2;
                    break;
                case "b":
                    Console.WriteLine("fout -1 punt");
                    score--;
                    break;
                case "c":
                    Console.WriteLine("fout -1 punt");
                    score--;
                    break;            
                default:
                    break;
            }
            Console.ReadKey();
            Console.Clear();

            //vraag 2
            Console.WriteLine("welke van deze pokemons is een starter pokemon");
            Console.WriteLine("a = lugia");
            Console.WriteLine("b = charmander");
            Console.WriteLine("c = pikachu");
            string inputVraag2 = Console.ReadLine();
            switch (inputVraag2)
            {
                case "a":
                    Console.WriteLine("correct -1 punt");
                    score --;
                    break;
                case "b":
                    Console.WriteLine("juist +2 punt");
                    score+=2;
                    break;
                case "c":
                    Console.WriteLine("fout -1 punt");
                    score--;
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"je score is {score}");
        }
    }
}
