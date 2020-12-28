using System;
using System.Security.Cryptography;

namespace Gunyher_d_s_grote_stemwijzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("beantwoord deze vragen door middel van j/n: ");
            Console.Write("werk je veel ?");
            string input = Console.ReadLine();

            if (input == "j")
            {
                Console.Write("koop je soms bruin brood: ");
                input = Console.ReadLine();
                Console.Clear();
                if (input == "j")
                {
                    Console.Write("ben je een seut: ");
                    input = Console.ReadLine();
                    Console.Clear();

                    if (input == "j")
                    {
                        Console.WriteLine("CD&V");
                    }
                    else
                    {
                        Console.Write("heb je vrienden");
                        input = Console.ReadLine();

                        if (input=="j")
                        {
                            Console.Write("staat jou wagen op de naam van je ouders");
                            input = Console.ReadLine();
                            if (input == "j")
                            {
                                Console.WriteLine("openvld");
                            }
                            else
                            {
                                Console.WriteLine("blanco ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("nva");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("je bent een Vlaams belanger");
                }

            }
            else
            {
                Console.Write("eet je quinoa?:");
                input = Console.ReadLine();

                if (input == "j")
                {
                    Console.WriteLine("groen");
                }
                else
                {
                    Console.WriteLine("krijg je vaak de schuld");
                    input = Console.ReadLine();

                    if (input == "j")
                    {
                        Console.WriteLine("spa");
                    }
                    else
                    {
                        Console.WriteLine("geloof je nog in sinterklaas");
                        input = Console.ReadLine();

                        if (input =="j")
                        {
                            Console.WriteLine("pvda");
                        }
                        else
                        {
                            Console.WriteLine("blanco");
                        }
                    }
                }
            }
        }
    }
}
