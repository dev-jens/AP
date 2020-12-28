using System;

namespace Weerstandsberekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            int ring1 = 1;
            int ring2 = 2;
            int ring3 = 3;
            double totaal = 12* Math.Pow(10,ring3);
            string tabel =@$"                       
                    ╔═══════════════╦═══════════════╦═══════════════╗
                    ║ring1          ║ ring2         ║ Totaal(Ohm)   ║
                    ╟───────────────╫───────────────╢───────────────╢
                    ║{ring1}              ║{ring2}              ║ {totaal}ohm      ║
                    ╚═══════════════╩═══════════════╩═══════════════╝                              ";

            Console.WriteLine(tabel);
 

        }
    }
}
