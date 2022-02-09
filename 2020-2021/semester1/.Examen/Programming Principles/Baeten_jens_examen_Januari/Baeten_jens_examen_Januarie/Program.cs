// baeten jens 1IT6
using System;

namespace Baeten_jens_examen_Januarie
{
    class Program
    {
        static void Main(string[] args)
        {
            char opnieuw = 'n';
            do
            {
                //DEEL1
                char[] signaal = MaakSignaal();
                Console.WriteLine($"onderschepte code:");
                PrintArray(signaal);
            
                //DEEL 2
                Console.WriteLine("\ndetectie van speciale tekens:");
                VisualiseerCode(signaal);

                //DEEL3
                AnalyseerCode(signaal);

                Console.WriteLine("Wenst u opnieuw te beginnen? [j/n]");
                opnieuw = char.Parse(Console.ReadLine().ToLower());

            } while (opnieuw != 'n'); 
        }

        static void PrintArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        static char[] MaakSignaal()
        {
            const int LENGTE_ARRAY = 100;
            Random r = new Random();
            char[] signaal = new char[LENGTE_ARRAY];

            for (int i = 0; i < signaal.Length; i++)
            {
                signaal[i] =(char)r.Next('A', 'Z' + 1);
            }
            return signaal;
        }

        static void VisualiseerCode(char[] signaal)
        {
            bool needColor = false;
            for (int i = 0; i < signaal.Length; i++)
            {
                needColor = NeedsColor(signaal[i]);

                if (needColor == true)
                {
                    WriteCharInRed(signaal[i]);
                }
                else
                {
                    Console.Write(".");   
                   
                }
            }
        }

        static bool NeedsColor(char letter)
        {
            bool isLetter = false;

            if (letter =='X' || letter == 'Z' || letter == 'Y' || letter == 'Q')
            {
                isLetter = true;
            }
            return isLetter;
        }

        static void WriteCharInRed(char letter)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(letter);
            Console.ResetColor();
        }

        static void AnalyseerCode(char[] signaal)
        {
            int specialCount = CountSpecials(signaal);
            Console.WriteLine($"\ner werden {specialCount} speciale tekens gevonden");
           
            if (Isverdacht(specialCount))
                Console.WriteLine("dit is een verdacht signaal");
            
            else
                Console.WriteLine("dit is geen verdacht signaal");
            
        }

        static int CountSpecials(char[] signaal)
        {
            int countSpecial = 0;
            for (int i = 0; i < signaal.Length; i++)
            {
                if (NeedsColor(signaal[i]))
                {
                    countSpecial++;
                }
            }
            return countSpecial;
        }

        static bool Isverdacht(int cijfer)
        {
            bool isVerdacht = false;
            if (cijfer % 3 == 0)
            {
                isVerdacht = true;
            }
            return isVerdacht;
        }
    }
}
