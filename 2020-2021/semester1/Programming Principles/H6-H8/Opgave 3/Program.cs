using System;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] naamArray = { };
            string[] ResultaatArray = { };
        }

        static bool VraagDetails(string[] naamArr, ConsoleColor kleur = ConsoleColor.Red)
        {
            Console.ForegroundColor = kleur;
            int index = 0;
            bool opnieuw = false;
            string input;
            do
            {
                opnieuw = false;
                Console.WriteLine("wat is ja naam");
                input = Console.ReadLine();

                index = -1;
                do
                {
                    index++;
                    if (naamArr[index] == input)
                    {
                        opnieuw = true;
                        Console.WriteLine("naam bestaat al");
                    }

                } while (index < naamArr.Length && naamArr[index] != null);
              
            } while (opnieuw);
            Console.ResetColor();
            if (input != "admin")
            {
                naamArr[index] = input;
                return false;
            }
            else
            {
                return true;
            }

        }

        static string Stemwijzer(bool Isadmin=false ,ConsoleColor kleur = ConsoleColor.Red)
        {
            int ja = 0;
            int nee = 0;
            Console.Write("stemwijzer");
            Console.Write("vrije sluitingstijden in de horica?");
            string antwoord = Console.ReadLine();
            if (antwoord == "ja")
            {
                Console.WriteLine("politie moet harder optreden");
                antwoord = Console.ReadLine();
                ja++;   
                if (antwoord == "ja")
                {
                    ja++;
                    Console.WriteLine($"De partij waar je best op stemt is VVD je hebt hiervoor {ja} keer ja geantwoord en {nee} keer nee");
                    
                }
                else
                {
                    nee++;
                    Console.WriteLine($"De partij waar je best op stemt is D66 je hebt hiervoor {ja} keer ja geantwoord en {nee} keer nee");
                }
            }
            else
            {
                Console.WriteLine("extra evenementen?");
                antwoord = Console.ReadLine();
                nee++;
                if (antwoord == "ja")
                {
                    Console.WriteLine($"De partij waar je best op stemt is BAS je hebt hiervoor {ja} keer ja geantwoord en {nee} keer nee");
                    ja++;
                }
                else
                {
                    Console.WriteLine($"De partij waar je best op stemt is LA je hebt hiervoor {ja} keer ja geantwoord en {nee} keer nee");
                    nee++;
                }
            }
        }
    }
}
