using System;

namespace Tafels
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 411;
            int multiplicator = 0;
            int uitkomst = getal * multiplicator;
           
            while(multiplicator < 11)
            {
                uitkomst = getal * multiplicator;
                Console.WriteLine($"{multiplicator} X {getal} = {uitkomst}");
                Console.ReadLine();
                Console.Clear();
                multiplicator++;
            }


            //methode 2 
            /*
             int getal = 411;
            int multiplicator = 0;
            int uitkomst = getal * multiplicator;
            Console.WriteLine($"{multiplicator} X {getal} = {uitkomst}");
            Console.ReadLine();
            Console.Clear();

          
            multiplicator++;
            uitkomst = getal * multiplicator;
            Console.WriteLine($"{multiplicator} X {getal} = {uitkomst}");
            Console.ReadLine();
            Console.Clear();

            herhalen X aantal 
             */



        }
    }
}
