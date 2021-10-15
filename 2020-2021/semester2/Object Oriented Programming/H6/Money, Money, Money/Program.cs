using System;

namespace Money__Money__Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        abstract class Rekening
        {
            private double saldo = 0;
            public double Saldo
            {
                get { return Saldo; }
            }
            public void VoegGeldToe(double hoeveel)
            {
                saldo += hoeveel;
            }

            public bool HaalGeldAf(double hoeveel)
            {
                if (saldo - hoeveel < 0)
                    return false;

                saldo -= hoeveel;
                return true;
            }

            public abstract double BankRente();
        }


        class BankRekening : Rekening
        {
            public override double BankRente()
            {
                if (Saldo > 100)
                {
                    return Saldo + (Saldo * 0.05);
                }
                return Saldo;
            }
        }
        class SpaarRekening : Rekening
        {
            public override double BankRente()
            {
                if (Saldo > 0)
                {
                    return Saldo + (Saldo * 0.02);
                }
                return Saldo;
            }
        }
        class ProRekening : SpaarRekening
        {
            public override double BankRente()
            {
                int aanatal1000 = (int)Saldo/1000;
                return base.BankRente() + aanatal1000 * 10;
            }
        }
    }
}
