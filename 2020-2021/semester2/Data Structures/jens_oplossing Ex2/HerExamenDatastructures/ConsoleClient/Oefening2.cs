using ConsoleClient.Comparer;
using System;

namespace ConsoleClient
{
    public class Oefening2
    {
        /// <summary>
        /// Startpunt van oef2: sorteeralgoritme
        /// zie opgave pdf voor meer info
        /// </summary>
        public void Start()
        {
            //In dit project vind je ook reeds een Insertion Sort.
            //Deze moet je verplicht gebruiken voor deze oefening.

            //Gebruik deze om deze lijst op 2 manieren te sorteren.
            //Manier 1: Volgens 'Height' sorteren van groot naar klein.
            //Manier 2: Eerst volgens geslacht (dames eerst), dan volgens naam.
            
            var list = CreateList();
            //Manier 1:
            //TODO: sorteer de lijst hier eerst volgens 'Height' in dalende volgorde
            InsertionSort IS = new InsertionSort();

            //Weergeven van de gesorteerde lijst
            Console.WriteLine("Standaard sortering volgens 'Height' in dalende volgorde");
            IS.Sort<Person>(list, new SortByheight());
            ShowList(list);

            //Manier 2:
            //TODO: sorteer de lijst hier eerst terug maar nu volgens geslacht EN Naam
            
            //weergeven van de gesorteerde lijst
            Console.WriteLine("2e sortering volgens 'Gender' and 'Name'");
            IS.Sort<Person>(list, new CompareByName());
            IS.Sort<Person>(list, new SortByGender());
            ShowList(list);
        }

        /// <summary>
        /// Maak een lijst met Pokemons
        /// </summary>
        /// <returns></returns>
        Person[] CreateList()
        {
            var list = new Person[5];

            list[0] = new Person()
            {
                Name = "Bert",
                Gender = Gender.Male,
                Weight = 70,
                Height = 150
            };
            list[1] = new Person()
            {
                Name = "Thomas",
                Gender = Gender.Male,
                Weight = 85,
                Height = 189
            };
            list[2] = new Person()
            {
                Name = "Diana",
                Gender = Gender.Female,
                Weight = 65,
                Height = 174
            };
            list[3] = new Person()
            {
                Name = "Xenia",
                Gender = Gender.Female,
                Weight = 58,
                Height = 168
            };
            list[4] = new Person()
            {
                Name = "Bart",
                Gender = Gender.Male,
                Weight = 58,
                Height = 167
            };

            return list;
        }

        /// <summary>
        /// Toon de lijst in de console
        /// </summary>
        /// <param name="list"></param>
        void ShowList(Person[] list)
        {
            foreach (var p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }
    }
}
