using System;
using System.Xml;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef een jaartal: ");
            int jaartal = int.Parse(Console.ReadLine());


            if (jaartal % 4 == 0)
            {
                if (jaartal % 100 != 0)
                {
                    Console.WriteLine("het is een schrikeljaar");
                }
                else
                {
                    if (jaartal % 400 == 0)
                    {
                        Console.WriteLine("schrikkel jaar");
                    }
                    else
                    {
                        Console.WriteLine("geen schrikkel jaar");
                    }
                }

            }
            else
            {
                Console.WriteLine("geen schrikkel jaar");
            }
        }
    }
}
