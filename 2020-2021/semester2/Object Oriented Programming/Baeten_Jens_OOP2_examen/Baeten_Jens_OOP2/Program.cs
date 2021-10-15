using System;

namespace Baeten_Jens_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rugzak rugzak = new Rugzak();
            Console.WriteLine("hoeveel items moeten er in de rugzak komen");
            int input = int.Parse(Console.ReadLine());

            Random r = new Random();
            for (int i = 0; i < input; i++)
            {
                int rGetal = r.Next(1, 3);
                if (rGetal == 1)
                {
                    Drinkbus drinkbus = new Drinkbus();
                    Console.WriteLine("Een drinkbus voor je. welke key moet dit krijgen?");
                    string naam = Console.ReadLine();
                    rugzak.RugzakInhoud.Add(naam, drinkbus);
                }
                else
                {
                    SportItem sportItem = new SportItem();
                    Console.WriteLine("Een sportItem voor je. welke key moet dit krijgen?");
                    string naam = Console.ReadLine();
                    rugzak.RugzakInhoud.Add(naam,sportItem );
                }
            }
            Console.Clear();

            for (int i = 0; i < rugzak.RugzakInhoud.Count; i++)
            {

                Console.WriteLine(rugzak.ToString()); 
                Console.ReadKey();
                Console.Clear();
                rugzak.Visualiseer();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
