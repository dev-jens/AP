using System;
using System.Collections.Generic;
using System.Text;

namespace BankManager2
{
    public enum RekeningState { Geldig, Blocked }
    class Rekening
    {
        private string naamKlant;

        public string Naamklant
        {
            get { return naamKlant; }
            set { naamKlant = value; }
        }

        private int balans;

        public int Balans
        {
            get { return balans; }
            set { balans = value; }
        }

        private string rekeningNummer;

        public string RekeningNummer
        {
            get { return rekeningNummer; }
            set { rekeningNummer = value; }
        }

        private RekeningState state = RekeningState.Geldig;

        public RekeningState State
        {
            get { return state; }
            set { state = value; }
        }


        public int HaalGeldAf(int bedrag)
        {
            if (bedrag > Balans)
            {
                bedrag = balans;
                Balans = 0;
                Console.WriteLine("niet al het geld kon terug gegeven worden");
                return bedrag;

            }
            else
            {
                Balans -= bedrag;
                return Balans;
            }

        }
        public void StortGeld(int bedrag)
        {
            Balans += bedrag;
        }

        public void ToonBalans()
        {
            Console.WriteLine($"{Naamklant},\t rekeningnr : {RekeningNummer} \t balans: {Balans}");
        }

        public void ChangeState()
        {
            if (State == RekeningState.Geldig)
            {
                State = RekeningState.Blocked;
            }
            else
            {
                state = RekeningState.Geldig;
            }
        }
        public void StimuleerOverdracht(Rekening houder1 , Rekening houder2)
        {
            for (int i = 0; i < 4; i++)
            {
                if (houder1.state == RekeningState.Geldig)
                {
                    Random r = new Random();
                    int geld = r.Next(0,100);
                    houder1.HaalGeldAf(geld);
                    houder2.StortGeld(geld);

                }
                else
                {
                    Random r = new Random();
                    int geld = r.Next(0, 100);
                    houder2.HaalGeldAf(geld);
                    houder1.StortGeld(geld);
                }
            }
        }
    }
}
