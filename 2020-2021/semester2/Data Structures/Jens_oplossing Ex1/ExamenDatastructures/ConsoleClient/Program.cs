using ClassLibrary;
using System;

namespace ConsoleClient
{
    /// <summary>
    /// Aan deze klasse moet je niets aanpassen. Dit is enkel het keuzemenu
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vaardigheidsproef Datastructures.");

            while(true)
            {
                Console.WriteLine("Geef het nummer van de oefening in");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        new Oefening1().Start();
                        break;
                    case "2":
                        new Oefening2().Start();
                        break;
                    case "3":
                        new Oefening3().Start();
                        break;
                    default:
                        Console.WriteLine("Sorry deze oefening bestaat niet");
                        break;
                }
            }

     
        }
    }
}
