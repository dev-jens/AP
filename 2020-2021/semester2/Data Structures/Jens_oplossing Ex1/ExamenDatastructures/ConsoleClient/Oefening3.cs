using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleClient
{
    public class Oefening3
    {
        /// <summary>
        /// Startpunt van oef3: Gebruik van een stack
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Welkom bij oefening 3. Geef telkens een woord of een getal");

            //Vul deze code aan...
            // .net stack
            var woordenlijst = new Stack<string>();
         

            int getal = 0;
            while (true)
            {
                var text = Console.ReadLine();
                if (int.TryParse(text, out getal))
                {
                    //Gebruiker geeft een getal in
                    if (woordenlijst.Count < getal) // als getal groter is dan het aantal woorden in de lijst
                    {
                        Console.WriteLine($">Sorry, de stack bevat nog maar {woordenlijst.Count} woord(en).");
                    }
                    else
                    {
                        for (int i = 0; i < getal; i++)
                        {
                            Console.WriteLine(">" + woordenlijst.Pop() + " ");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    //Gebruiker geeft een woord in dus toevoegen op stack met push methode
                    woordenlijst.Push(text);
                    
                }
            }
        }
    }
}
