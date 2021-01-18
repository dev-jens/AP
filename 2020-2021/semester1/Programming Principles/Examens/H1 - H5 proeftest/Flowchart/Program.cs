using System;


namespace Flowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je doen? Covidbeslissingshelper(c) of de CovidQuiz(q)");
            string input = Console.ReadLine();

            switch (input)
            {
                case "c":
                    Console.Write("vertoon je symptomen (j/n): ");
                    input = Console.ReadLine();

                    if (input == "j")
                    {
                        Console.WriteLine("ga in quarantaine en aat je testen");
                        Console.Write("test je positief? (j/n): ");
                        input = Console.ReadLine();

                        if (input == "j")
                        {
                            Console.WriteLine("7 dagen quarantaine");
                        }
                        else
                        {
                            Console.WriteLine("ga terug naar school wanner genezen");
                        }
                    }
                    else
                    {
                        Console.Write("in nou contact gekomen met iemand die ziek is?: ");
                        input = Console.ReadLine();

                        if (input =="j")
                        {
                            Console.WriteLine("ga in quarantaine en aat je testen");
                            Console.Write("test je positief? (j/n): ");
                            input = Console.ReadLine();

                            if (input == "j")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("7 dagen quarantaine");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("ga terug naar school wanner genezen");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("je mag naar school blijven gaan");
                        }
                    }

                    break;

                case "q":
                    Random r = new Random();
                    int getal = r.Next(1,6);
                    Console.WriteLine($"{getal} dagen");
                    Console.WriteLine("hoeveel dagen nog voor dat je moet testen");
                    int inputDagen = int.Parse(Console.ReadLine());

                    if (inputDagen == (getal-1))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("correct");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("fout");
                    }

                    break;


                default:
                    Console.WriteLine("verkeerde invoer");
                    break;
            }

            Console.ResetColor();
        }
    }
}
