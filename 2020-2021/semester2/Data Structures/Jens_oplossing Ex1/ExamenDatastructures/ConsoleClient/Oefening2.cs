using ConsoleClient.Generic; // 
using System;


namespace ConsoleClient
{
    public class Oefening2
    {
        /// <summary>
        /// Startpunt van oef2: sorteeralgoritme en generics
        /// zie opgave pdf voor meer info
        /// </summary>
        public void Start()
        {
            //In de classlibrary vind je een Selection Sort, maar deze is nog niet generiek.
            //Je kan deze ofwel kopiëren naar dit project en omvormen met generics (voorkeur)
            //ofwel maak je een Sort Algoritme die enkel Pokemon kan sorteren.
            //(dit kost je echter enkele punten)

            Pokemon[] list = CreateList();

            //TODO: sorteer de lijst hier eerst volgens 'Name' in alfabetische volgorde
            //Zorg dat de pokemon klasse zelf de volgorde bepaalt.
            SelectionSort SS = new SelectionSort();


            //Weergeven van de gesorteerde lijst
            Console.WriteLine("Standaard sortering volgens 'Name'");
            
            SS.Sort<Pokemon>(list);
            ShowList(list);

            //TODO: sorteer de lijst hier eerst terug maar nu volgens Height en in dalende volgorde

            //weergeven van de gesorteerde lijst
            Console.WriteLine("2e sortering volgens 'Height' in dalende volgorde");
            SS.Sort<Pokemon>(list, new CompareByHeight());
            ShowList(list);
        }

        /// <summary>
        /// Maak een lijst met Pokemons
        /// </summary>
        /// <returns></returns>
        Pokemon[] CreateList()
        {
            var list = new Pokemon[4];

            list[0] = new Pokemon()
            {
                Name = "Ivysaur",
                Weight = 130,
                Height = 10
            };
            list[1] = new Pokemon()
            {
                Name = "Bulbasaur",
                Weight = 69,
                Height = 7
            };
            list[2] = new Pokemon()
            {
                Name = "Venusaur",
                Weight = 1000,
                Height = 20
            };
            list[3] = new Pokemon()
            {
                Name = "Charmander",
                Weight = 85,
                Height = 6
            };

            return list;
        }

        /// <summary>
        /// Toon de lijst in de console
        /// </summary>
        /// <param name="list"></param>
        void ShowList(Pokemon[] list)
        {
            foreach (var p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }
    }
}
