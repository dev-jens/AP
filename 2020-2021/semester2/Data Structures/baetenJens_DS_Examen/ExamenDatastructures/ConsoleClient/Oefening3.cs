using System;

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
            int getal = 0;
            while (true)
            {
                Stack<string> stackArr = new Stack<string>();
                int counter = 0;
                var text = Console.ReadLine();
                if (int.TryParse(text, out getal))
                {
                    //Gebruiker geeft een getal in
                    if (counter > getal)
                    {
                        for (int i = 0; i < getal; i++)
                        {
                           Console.Write(stackArr.Pop());
                        }
                    }
                    else
                    {
                        Console.WriteLine($">Sorry, de stack bevat nog maar {counter} woord(en).");
                    }

                    //Console.WriteLine($">Sorry, de stack bevat nog maar {Count} woord(en).");
                }
                else
                {
                    //Gebruiker geeft een woord in
                    stackArr.Push(text);
                    counter++;
                }
            }
        }
    }
}
