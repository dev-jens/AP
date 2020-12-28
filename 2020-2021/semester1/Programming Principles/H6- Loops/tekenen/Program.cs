using System;

namespace tekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef hoogte tussen 2 en 20: ");
            int inputHoogte = int.Parse(Console.ReadLine());

            Console.Write("geef breedte tussen 2 en 20: ");
            int inputBreedte = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (inputHoogte >= 2 && inputHoogte <= 20 && inputBreedte >= 2 && inputBreedte <= 20)
            {
                for (int i = 1; i <= inputHoogte; i++)
                {
                    for (int j = 1; j <= inputBreedte; j++)
                    {
                        if (i == 1 || i == inputHoogte)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            if (j == 1 || j == inputBreedte)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("u moeder is een kak hoer");
            }
           
        }
        
    }
}
