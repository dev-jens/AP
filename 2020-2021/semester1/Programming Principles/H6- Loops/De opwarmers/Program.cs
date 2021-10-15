using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

namespace De_opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //int n = 101;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //2

            //int n =100 ;
            //for (int i = n; i >0 ; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //3

            //const int n = 101;
            //const int deelbaar_1 = 2;

            //for (int i = 0; i < n; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //4
            //const int n = 101;
            //const int deelbaar_1 = 2;
            //for (int i = 1; i < n; i++)
            //{
            //    if (i % deelbaar_1 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //5
            //const int n = 10;
            //int i = 0;
            //int som = 0;

            //while (i < n)
            //{
            //    i++;
            //    som += i;   
            //}
            //Console.WriteLine(som);

            //6
            //int n = 10;
            //int som = 0;
            //for (int i = 0; i < n+1; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        som += i;
            //    }
            //}
            //Console.WriteLine(som);

            //7
            //int n = 10;
            //int som = 0;
            //for (int i = 0; i < n + 1; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        som += i;
            //    }
            //}
            //Console.WriteLine(som);

            //--------------------------------------------------------------------------------------------------------------

            // 8
            //int stopWaarde = 0;
            //int som = 0;

            //Console.WriteLine("getal: ");
            //int input = int.Parse(Console.ReadLine());
            //som += input;

            //while (input != stopWaarde)
            //{

            //    Console.WriteLine($"Voer een getal in, het programma stopt als je {stopWaarde} ingeeft");
            //    input = int.Parse(Console.ReadLine());
            //    som += input;
            //}

            //Console.WriteLine($"Je gaf {stopWaarde} in, de som van alle voorgaande waardes is {som}");

            //9

            //int stopWaarde = 0;
            //int striktPos = 0;
            //int striktNeg = 0;
            //int input = 0;
            //do
            //{
            //    Console.WriteLine($"Voer een getal in, het programma stopt als je {stopWaarde} ingeeft");
            //    input = int.Parse(Console.ReadLine());

            //    if (input > 0 )
            //    {
            //        striktPos++;
            //    }
            //    else if (input < 0)
            //    {
            //        striktNeg++;
            //    }

            //} while (input != stopWaarde);

            //Console.WriteLine($"Je gaf {stopWaarde} in, je gaf {striktPos} strikt pos getallen in en {striktNeg} strikt negative getallen in");

            //10

            //int stopwaarde = -32768;
            //int input = 0;
            //int striktPos = 0;
            //int striktNeg = 0;
            //int nul = 0;

            //do
            //{
            //    Console.Write($"Voer een getal in, het programma stop als je {stopwaarde} in geeft:  >>> ");
            //    input = int.Parse(Console.ReadLine());

            //    if (input > 0)
            //    {
            //        striktPos++;
            //    }
            //    else if (input < 0 && input != stopwaarde)
            //    {
            //        striktNeg++;
            //    }
            //    else
            //    {
            //        nul++;
            //    }

            //} while (input != stopwaarde);

            //Console.WriteLine($"Je gaf {stopwaarde} in, je gaf {striktPos} strikt pos getallen in,  {striktNeg} strikt negative getallen in en {nul} keer nul ");


            //11
            //int stopWaarde = 0;
            //int product = 1;
            //int input = 1;

            //do
            //{
            //    product *= input;
            //    Console.Write("geef een willekeurig getal, Typ 0 om te stoppen: ");
            //    input = int.Parse(Console.ReadLine());

            //} while (input != stopWaarde);

            //Console.WriteLine(product);



        }
    }
}
