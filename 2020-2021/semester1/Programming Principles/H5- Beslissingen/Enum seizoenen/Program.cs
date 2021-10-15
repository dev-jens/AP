using System;

namespace Enum_seizoenen
{
    class Program
    {
        public enum seizoenen {Winter, Herfst, Lente, Zomer, onbekend}

        static void Main(string[] args)
        {
            Console.Write("geef een maand (1-12): ");
            int input = int.Parse(Console.ReadLine());

            seizoenen seizoen;

            switch (input)
            {
                case 1:
                case 2:
                case 3:
                    seizoen = seizoenen.Winter;
                break;
                case 4:
                case 5:
                case 6:
                    seizoen = seizoenen.Lente;
                    break;
                case 7:
                case 8:
                case 9:
                    seizoen = seizoenen.Zomer;
                    break;
                case 10:
                case 11:
                case 12:
                    seizoen = seizoenen.Herfst;
                    break;
                default:
                    seizoen = seizoenen.onbekend;
                    break;
            }

            if (seizoen == seizoenen.Winter || seizoen ==seizoenen.Herfst)
            {
                Console.WriteLine($"De maand {input} ligt in een warm seizoen");
            }
            else
            {
                Console.WriteLine($"De maand {input} ligt in een koud seizoen");
            }



        }
    }
}
