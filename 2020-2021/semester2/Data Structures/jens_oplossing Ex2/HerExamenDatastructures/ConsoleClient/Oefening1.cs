using System;
using ConsoleClient.DLL;

namespace ConsoleClient
{
    public class Oefening1
    {
        /// <summary>
        /// Startpunt van oef1
        /// zie opgave pdf voor meer info
        /// </summary>
        public void Start()
        {
            //Vul deze code aan. Gebruik de juiste datastructuur om de getallen in te bewaren.
            //Merk op: Zowel het toevoegen, invoegen en verwijderen van eender welk getal MOETEN elk een O(1) operatie zijn.
            //Opoeken van een bepaald getal mag een O(n) operatie zijn.
            
            //Opdracht 1: kies de juiste datastructuur om de getallen in te bewaren om alle mee opdrachten te kunnen doen.
            //(Je mag dus geen bijkomende datastructuren gebruiken)
            //je mag onderaan of in aparte bestanden eventuele klassen toevoegen die je nodig hebt om de oefening te kunnen maken
            Console.WriteLine("Welkom bij oef 1. Geef na elkaar 5 verschillende gehele getallen in");
            int counter = 1;
            int getal = 0;
            
            List list = new List();
            while (counter <= 5)
            {
                var text = Console.ReadLine();
                if (int.TryParse(text, out getal))
                {
                  
                    list.AddLast(getal);
                    counter++;
                }
                else
                    Console.WriteLine("een GEHEEL GETAL ingeven AUB.");
            }

            //Opdracht 2: Toon alle getallen in ingegeven volgorde
            Console.WriteLine("opdr.2: in volgorde van ingave");
            
            Node n = list.First;
            while (n != null)
            {
                Console.WriteLine(n.Value);
                n = n.Next;
            }


            //Opdracht 3: Toon alle getallen in omgekeerde volgorde (dus het laatste ingegeven wordt eerst getoond)
            Console.WriteLine("opdr.3: in omgekeerde volgorde");
            n = list.Last;
            while (n != null)
            {
                Console.WriteLine(n.Value);
                n = n.Prev;
            }
           

            //Opdracht 4: Toon enkel het 3e ingevoerde getal.
            Console.WriteLine("opdr.4: 3e ingevoerde getal");
            n = list.First;
            int teller = 1;
            while (teller <= counter)
            {
                if (teller == 3)
                {
                    Console.WriteLine(n.Value);
                    break; // why not tims dams?
                }
                n = n.Next;
                teller++;
            }

            Console.WriteLine("opdr.5: ingevoerde getal");
            list.RemoveNode(n);
            n = list.First;
            while (n != null)
            {
                Console.WriteLine(n.Value);
                n = n.Next;
            }
        }
    }
}
