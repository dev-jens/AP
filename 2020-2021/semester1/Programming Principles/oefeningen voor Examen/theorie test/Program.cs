using System;

namespace theorie_test
{
    class Program
    {
        static int[] MaakLijst( int lengte , int begin) 
        {
           
            int[] resultaat = new int[lengte];
            for (int i = 0; i < lengte; i++)
            {
                Random r = new Random();
                int ramdom = r.Next(0, 10);
                if (i == 0)
                 {
                     resultaat[i] = begin;
                 }
                 else
                 {
                     resultaat[i] = ramdom;
                 } 
             

            }
            return resultaat;
        }
        static void Main(string[] args)
        {
            int[] nieuwelijst = MaakLijst(4,1);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(nieuwelijst[i]);
            }
           
        }
    }
}
