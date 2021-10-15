using System;

namespace Opgave_1
{
    class Program
    {
        static void Do()
        {
            Console.WriteLine("Do");
            Console.Beep(264, 1000); // do
        }

        static void Re()
        {
            Console.WriteLine("Re");
            Console.Beep(297, 1000); // re 
        }

        static void Mi()
        {
            Console.WriteLine("Mi");
            Console.Beep(330, 1000); // mi 
        }

        static void Fa()
        {
            Console.WriteLine("Fa");
            Console.Beep(352, 1000); //fa
        }

        static void Sol()
        {
            Console.WriteLine("Sol");
            Console.Beep(396, 1000); // sol 
        }

        static void La()
        {
            Console.WriteLine("La");
            Console.Beep(440, 1000); // la
        }

        static void Si()
        {
            Console.WriteLine("Si");
            Console.Beep(495, 1000); //si
        }

        static void Do2()
        {
            Console.WriteLine("Do2");
            Console.Beep(528, 1000); //do2
        }

        static void Main(string[] args)
        {
            Sol();
            La();
            Si();
            Do();
            Mi();
            Mi();
            Re();
            Do();
            Si();





        }
    }
}
