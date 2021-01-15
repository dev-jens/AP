
using System;

namespace Methoden
{
    class Program
    {
        static int Kwadraat(int getal)
        {
            return getal * getal;
        }
        static double straal(int diameter)
        {
            return diameter / 2;
        }
        static double omtrekCirlek(int straal) 
        {
            return Math.PI * straal * 2;
        
        }
        static double OppCirkel(double straal)
        { 
            return Math.PI * Math.Pow(straal, 2);
        }
        static double GrootsteGetal(int a , int b)
        {
            if (a < b)
            {
                return b;
            }
            return a;
        }
        static bool Iseven(int a) 
        {
            bool isEven = false;
            if (a % 2 == 0)
            {
                isEven = true;
            }
            return isEven;
        }
        static void ToonOnEvenNummers(int n)
        {
            for (int i = 1; i <= n; i+=2)
            { 
                    Console.Write($"{i},");
           
            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("geef een getal >>> ");
            int get = int.Parse(Console.ReadLine());
            ToonOnEvenNummers(get);




            //Console.Write($"geef een diamter: >>> ");
            //int getal = int.Parse(Console.ReadLine());

            //double oppCirkel =OppCirkel(getal);
            //double omtrekCirckel = omtrekCirlek(getal);

            //Console.WriteLine("opp = " + oppCirkel);
            //Console.WriteLine("omtrek = " + omtrekCirckel);

            //Console.Write($"geef een getal: >>> ");
            //int getal2 = int.Parse(Console.ReadLine());

            //double grootsteGet = GrootsteGetal(getal, getal2);
            //Console.WriteLine($"het grootste getak is {grootsteGet}");

            //bool isEvenGetal = Iseven(getal2);
            //Console.WriteLine($"is {getal2} even :{isEvenGetal} ");
        }


    } 
}
