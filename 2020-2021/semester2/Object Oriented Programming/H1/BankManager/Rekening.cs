using System;
using System.Collections.Generic;
using System.Text;

namespace BankManager
{   
    public enum RekeningState {Geldig,Blocked }
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
            if (bedrag> Balans)
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

    }
}
