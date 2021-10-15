using System;

namespace Opgave2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            if (SetupCasino("jens"))
            {
                CasinoLoop();
            } 
            
        }
        static bool SetupCasino(string naam, int lengte = 20, int breedte =120)
        {
            if (lengte < 1 || breedte < 1)
            {
                return false;
            }

            Console.WindowHeight = lengte;
            Console.WindowWidth = breedte;

            for (int i = 0; i < breedte; i++)
            {
                Console.SetCursorPosition(i,0);
                Console.Write("*");
                Console.SetCursorPosition(i,2);
                Console.Write("*");
            }

            Console.SetCursorPosition(0,1);
            Console.Write($"Welkom bij Casino AP met u gastheer {naam}");

            Console.SetCursorPosition(0, 3);
            Console.WriteLine("Druk op enter om Geld te maken");
            Console.ReadKey();
            Console.Clear();

            return true;
        }

        static void CasinoLoop()
        {
            int keuze = 0;
            int geld = 0;
            while (keuze != -1)
            {
                Console.Clear();
                Console.WriteLine($"Je hebt {geld} euro.");
                keuze = ToonMenu();
                Console.Clear();
                switch (keuze)
                {
                    case 1:
                        geld += RaadHetGetal();
                        break;
                    case 2:
                        geld += RekenenMaar();
                        break;
                    case 3:
                        geld += ArrayGame();
                        break;
                    default:
                      
                        //ShowEnding(geld);
                        keuze = -1;
                        break;

                }
                Console.WriteLine("Druk toets om verder te gaan");
                Console.ReadKey();
            }
        }

        static int ToonMenu()
        {
            int keuze = 0;

            do
            {
                Console.WriteLine("Geef keuze");
                Console.WriteLine("\t1. Raad het getal");
                Console.WriteLine("\t2. Rekenen maar");
                Console.WriteLine("\t3. Raad de sequentie");
                Console.WriteLine("*****");
                Console.WriteLine("-1 is stoppen");
                keuze = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (keuze != 1 && keuze != 2 && keuze != -1 && keuze != 3);

            return keuze;
        }

        static int RaadHetGetal() 
        {
            Random r = new Random();
            int raden = r.Next(1,11);
            int i = 0;
            int gok = 0;
            Console.WriteLine("Jiplaaa RaadHetGetal Goeie keuze");
            Console.WriteLine("raad een getal tussen 1-10. inhoeveel keer ga je het raden");
            int aantal = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"Welk getal is het(aantalpogingen is {i}) ?");
                gok = int.Parse(Console.ReadLine());
                i++;

            } while (gok != raden);

            if (i == aantal)
            {
                Console.WriteLine("+50");
                return 50;
            }
            else if(i <= aantal - 2 || i <= aantal +2)
            {
                Console.WriteLine("+5");
                return 5;
            }

            Console.WriteLine("-5");
            return -5;
            
        }

        static int RekenenMaar()
        {
            const int AANTAL_OEF = 5;
            Random r = new Random();
            int getal1, getal2, product =0, score = 0;
           
            for (int i = 0; i < AANTAL_OEF; i++)
            {
                getal1 = r.Next(1, 11);
                getal2 = r.Next(1, 11);

                Console.Write($"{getal1} x {getal2} = ");
                int input = int.Parse(Console.ReadLine());
                product = getal1 * getal2;

                if (product == input)
                {
                    score += 5;
                }
                else
                {
                    score -= 5;
                }

            }
            Console.WriteLine($"je score is {score}");
            return score;
        }

        static int ArrayGame(int lengte=10)
        {
            int score = 0 , index=0;
            Random r = new Random();
            bool[] lijst = new bool[lengte];
            for (int i = 0; i < lijst.Length; i++)
            {
                int ramdom = r.Next(0, 2);
                if (ramdom == 0)
                {
                    lijst[i] = false;
                }
                else
                {
                    lijst[i] = true;
                }

            }
            bool correct = true;
             
            do
            {
                Console.Write("O=false, 1=true");
                int input = int.Parse(Console.ReadLine());
                if (input == 0 && lijst[index] == false || input == 1 && lijst[index] == true)
                {
                    Console.WriteLine("gg");
                    index++;
                }
                else
                {
                    correct = false;
                    Console.WriteLine("boe");
                }

               
            } while (correct == true && index < lijst.Length);

            Console.WriteLine($"Je behaalde een sequentie van {index} juiste gokken. Dat is {index * 5} euro waard.");
            for (int i = 0; i < lijst.Length; i++)
            {
                Console.Write($"{lijst[i]} ");
            }
            return index * 5;
        }

    }
}
