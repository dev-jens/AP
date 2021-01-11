using System;

namespace Cooldown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef een oefening nummer :<< ");
            int keuze = int.Parse(Console.ReadLine());

            switch (keuze)
            {
                case 1:
                    for (int i = 1; i <= 100; i+=2)
                    {
                        if (i%3 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i <= 99; i+=5)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 3:
                    int lengte = 8;
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("");
                        for (int j = 1; j <= lengte; j++)
                        {
                            Console.Write($"{j}X{i}={i*j},");   
                        }
                    }
                    break;
                case 4:
                    int som =0;
                    int t = 9;

                    for (int i = 1; i < 7; i++)
                    {
                        Console.Write($"{t} + ");
                        som += t;
                        t = (t * 10) + 9;
                    }
                    Console.WriteLine(som);  
                    break;
                case 5:
                    const int TELLER = 1;
                    Console.Write("geef een getal: >>> ");
                    int n = int.Parse(Console.ReadLine());
                    double somBreuk = 0;
                    for (double i = 1.0 ; i <= n; i++)
                    {
                        if (i < n)
                        {
                            Console.Write($"{TELLER}/{i} +");
                            somBreuk += TELLER / i;
                        }
                        else
                        {
                            Console.Write($"{TELLER}/{i} = ");
                            somBreuk += TELLER / i;
                            Console.Write(Math.Round(somBreuk,5));
                        }
                    }
                    break;
                case 6:
                    int input, somTeller = 0, aantalkeren = 0, gem;
                    do
                    {
                        Console.Write("geef een getal ");
                        input = int.Parse(Console.ReadLine());
                        if (input != -1)
                        {
                            somTeller += input;
                            
                        }
                        aantalkeren++;

                    } while (input != -1);
                    gem = somTeller / aantalkeren;
                    if (gem == -1)
                    {
                        Console.WriteLine("er zijn niet genoeg getallen in gevuld voor een gemiddelde");
                    }
                    else
                    {
                        Console.WriteLine(gem);
                    }
                 
                    break;
                default:
                    Console.WriteLine("u moeder is een kak hoer");
                    break;
            }

          
            
        }
    }
}
