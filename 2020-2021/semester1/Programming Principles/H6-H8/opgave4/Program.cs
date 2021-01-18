using System;

namespace opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de moeilijkheidsgraad (1-9)");
            int moeilijkheidsGraad = int.Parse(Console.ReadLine());
            Console.WriteLine("krijgt de trainee een start bonus? (j-n)");
            string bonus = Console.ReadLine();
            bool startbonus = true;
            if (bonus == "j")
                startbonus = true;
            
            else
                startbonus = false;

            double startbudget = BudgetGen(moeilijkheidsGraad, startbonus);
            int i = 0;
            int[] prijzen = new int[20];
            bool[] Isgekocht = new bool[20];
            
            while(startbudget > 0 && i < 20)
            {
                int kost = HuisPrijs();
                Console.WriteLine(HuisPrijs());
                Console.WriteLine($"je budget is nu {startbudget}");
                Console.WriteLine("---------------");
                Console.WriteLine($"wil je dit huis kopen? het kost {kost}");
                string kopenOfNiet = Console.ReadLine();
                prijzen[i] = kost;
               

                if (kopenOfNiet == "j")
                {
                    startbudget -= kost;
                    Isgekocht[i] = true;
                }
                else
                    Isgekocht[i] = false;
                i++;
            }

            Console.WriteLine(" ");
            for (int j = 0; j < i; j++)
            {
                if (Isgekocht[j] == true)
                {
                    Console.WriteLine($"huis met prijs {prijzen[j]} euro heb je gekocht");
                }
                else
                {
                    Console.WriteLine($"huis met prijs {prijzen[j]} euro heb je niet gekocht");
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Je spendeerde gemddelde {Gemidelde(prijzen, Isgekocht)} euro aan een huis");

        }

        static double BudgetGen(int moeilijkheidsGraad, bool startbonus = true)
        {
            double basisBudget = 5000;
            if (startbonus)
            {
                basisBudget += 2500;
            }

            return basisBudget - (moeilijkheidsGraad * 100);
        }

        static int HuisPrijs()
        {
            Random r = new Random();
            int slaapkamers = r.Next(1, 4);
            int terras = r.Next(1, 11);

            int prijs = 1000;
            bool heeftTerras = false;
            prijs += (slaapkamers * 120);

            if (terras <= 3)
            {
                heeftTerras = true; 
                prijs += 450;
            }

            if (!heeftTerras)
                Console.Write($"Huis met {slaapkamers} slaapkamers heeft geen terras: {prijs} euro ");
            else
                Console.Write($"Huis met {slaapkamers} slaapkamers heeft een terras: {prijs} euro ");
            return prijs;
        }

        static double Gemidelde(int[] prijzen , bool[] gekocht)
        {
            double gem = 0;
            int aangeckocht = 0;
            for (int i = 0; i < prijzen.Length; i++)
            {
                if (gekocht[i] == true)
                {
                    gem += prijzen[i];
                    aangeckocht++;
                    
                }
            }

            return gem / aangeckocht;
        }
    }
}
