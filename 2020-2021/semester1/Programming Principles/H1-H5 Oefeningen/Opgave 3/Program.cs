using System;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double cheesyCrust = 5, martainMeal = 2.8, pegasusLime = 12.4;
            double top_Pies_cr = 10, top_pies = 15, top_Italian = 15;
            double totaal = 0;
            double transportKosten = 0;
            string chefsExtra = "";



            Console.Write(" 1-Cheesy crust, 2-Martian meal,3-Pegasus lime");
            int pizzaBodem = int.Parse(Console.ReadLine());

            if (pizzaBodem == 1)
            {
                totaal += cheesyCrust;
            }
            else if (pizzaBodem == 2)
            {
                Console.Write("Geef je leeftijd voor deze bodem moet je ouder zijn dan 54 +");
                int leeftijd = int.Parse(Console.ReadLine());
                if (leeftijd >= 54)
                {
                    totaal += martainMeal;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRRORRRR");
                    Console.ResetColor();
                }    
            }
            if (pizzaBodem == 3)
            {
                totaal += pegasusLime;
            }

            Console.Write(" 1-Endrali pies  2 - Italian Cheese, 3-Geen");
            int pizzaTopping = int.Parse(Console.ReadLine());

            switch (pizzaTopping)
            {
                case 1:
                    if (pizzaBodem == 1)
                    {
                        totaal += top_Pies_cr;
                    }
                    else
                    {
                        totaal += top_pies;
                    }
                    break;
                case 2:
                    totaal += top_Italian;
                    break;
                case 3:
                    Console.Write($"Chef's extra? (dikke fluim)(J/N): ");
                    chefsExtra = Console.ReadLine().ToUpper();
                    if (chefsExtra == "J")
                    {
                        totaal += 1;
                    }
                    else
                    {
                        totaal += 0;
                    }
                    
                    break;
                default:
                    break;
            }

            Console.Write("geef het afleveradres in lichtjaren (1-100): ");
            int inputLichtjaren = int.Parse(Console.ReadLine());
            if (inputLichtjaren >= 1 && inputLichtjaren <= 1 )
            {
                Console.WriteLine($"Lichtjaren {inputLichtjaren}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            if (pizzaBodem == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("C");
            }
            else if (pizzaBodem == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("M");
            }
            else if(pizzaBodem == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("P");
            }

            switch (pizzaTopping)
            {
                case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("O");
                    break;
                case 2:
                      Console.ForegroundColor = ConsoleColor.Yellow;
                      Console.Write("O");
                    break;
                case 3:
                    if (chefsExtra == "j")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("E");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Z");
                    }
                    break;
                default:
                    break;
            }
            Console.ResetColor();

            Console.Write("hoeveel lichtjaren ver: ");
            int lichtjaaren = int.Parse(Console.ReadLine());

            if (lichtjaaren < 10)
            {
                transportKosten = 25;
            }
            else if (lichtjaaren >= 10)
            {
                transportKosten = Math.Sqrt(lichtjaaren / totaal) + totaal;
            }

            if (chefsExtra == "J")
            {
                transportKosten *= 0.1;
            }


            //Console.WriteLine($"{}     {} \n" +
            //  $"{topping}, Chef's extra: {chefsExtra}     {pizzaTopping} \n" +
            //  $"________________________________________________________\n" +
            //  $"Totaal pizza      {totaal} \n" + "\n" +
            //  $"Afstand       {lichtjaaren} lichtjaren \n" +
            //  $"Transportkosten       {transportKosten} \n" +
            //  $"________________________________________________________\n" +
            //  $"TOTAAL        {totaal} \n" +
            //  $"********************************************************\n" +
           










        }
    }
}
