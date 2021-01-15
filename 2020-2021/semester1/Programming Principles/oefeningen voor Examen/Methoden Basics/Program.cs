using System;

namespace Methoden_Basics
{
    class Program
    {
        static void Myintro(string naam, int leeftijd, string straat)
        {
            Console.WriteLine($"ik ben {naam}");
            Console.WriteLine($"ik ben {leeftijd} jaar oud");
            Console.WriteLine($"mijn adres is {straat}");          
        }

        static double Grootste(int get1 , int get2 , int get3)
        {
            double grootste = 0;
            if (get1 < get2 && get3 < get2)
            {
                grootste = get2;
            }
            else if (get1 > get2 && get1 > get3)
            {
                grootste = get1;
            }
            else
            {
                grootste = get3;
            }

            return grootste; 
        }

        static double TelOp( int getal1, int getal2)
        {
            return getal1 + getal2;
        }

        static double TrekAf(int getal1, int getal2)
        {
            return getal1 - getal2;
        }
        
        static double VermenigVuldig(int getal1, int getal2)
        {
            return getal1 * getal2;
        }
        
        static double Deel(int getal1,  int getal2)
        {
            return getal1 / getal2;
        }

        static string PasswordGen(int lengte)
        {
            Random r = new Random();
            string password = "";

            for (int i = 0; i < lengte; i++)
            {
                switch (r.Next(0, 3))
                {
                    case 0: //cijfer
                        password += r.Next(0, 10);
                        break;
                    case 1: //kleine letters
                        password += (char)r.Next('a', 'z' + 1);
                        break;
                    case 2: //hoofdletters
                        password += (char)r.Next('A', 'Z' + 1);
                        break;
                }

            }

            return password;
        }
        
        static void Main(string[] args)
        {
            // intro function whoami
            Myintro("jens baeten",20,"korenbloemdreef 35");
            Console.WriteLine("");

            // grootste getal
            Console.WriteLine("geef 3 getallen: ");
            int get1 = int.Parse(Console.ReadLine());
            int get2 = int.Parse(Console.ReadLine());
            int get3 = int.Parse(Console.ReadLine());

            double grootsteGetal1 = Grootste(get1, get2, get3);
            Console.WriteLine($"het grootste getal is: {grootsteGetal1}");
            Console.WriteLine("");

            // rekenmachine
           
            Console.WriteLine("Wat voor soort bewerking wilt u doen");
            Console.WriteLine("1: optellen");
            Console.WriteLine("2: aftrekken");
            Console.WriteLine("3: vermenigvuldigen");
            Console.WriteLine("4: delen");
            Console.Write("geef een getal << ");
            int keuze = int.Parse(Console.ReadLine());

            Console.WriteLine("geef nu 2 getallen waar u deze bewerking mee wilt uitvoeren");
            Console.Write("getal1: ");
            int getal1 = int.Parse(Console.ReadLine());
            Console.Write("getal2: ");
            int getal2 = int.Parse(Console.ReadLine());


            switch (keuze)
            {
                case 1:
                    Console.WriteLine(TelOp(getal1, getal2));
                    break;
                case 2:
                    Console.WriteLine(TrekAf(getal1, getal2));
                    break;
                case 3:
                    Console.WriteLine(VermenigVuldig(getal1, getal2)); 
                    break;
                case 4:
                    Console.WriteLine(Deel(getal1, getal2));
                    break;

                default:
                    Console.WriteLine("foute invoer ma dude");
                    break;
            }

            Console.WriteLine("geef de lengte van uw password: << ");
            int lengte = int.Parse(Console.ReadLine());
            Console.WriteLine(PasswordGen(lengte));



        }
    }
}
