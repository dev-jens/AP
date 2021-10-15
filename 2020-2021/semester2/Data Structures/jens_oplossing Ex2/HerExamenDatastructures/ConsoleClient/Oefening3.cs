using System;

namespace ConsoleClient
{
    public class Oefening3
    {
        /// <summary>
        /// Startpunt van oef3: Gebruik van een queue
        /// zie opgave pdf voor meer info
        /// </summary>
        public void Start()
        {
            //In dit project vind je reeds een Queue.
            //Deze moet je verplicht gebruiken voor deze oefening.

            Console.WriteLine("Welkom bij oefening 3. Geef telkens een woord in.");
            string zin = "";
            int counter = 1;
            var linqueue = new LineairQueueString(5,true);
            //Vul deze code aan...
            while (true)
            {
                if (counter <= 5)
                {
                    var text = Console.ReadLine();
                    linqueue.Enqueue(text);
                    counter++;

                }
                else
                {
                    Console.WriteLine("dit is momenteel de zin");
                    for (int i = 0; i < 5; i++)
                    {
                        
                        Console.Write(linqueue.Dequeue() + " ");
                      
                       
                    }
                    counter = 0;
                }
               
              
                //TODO: vul verder aan
            }
        }
    }
}
