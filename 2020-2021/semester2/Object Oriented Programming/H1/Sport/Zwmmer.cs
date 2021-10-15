using System;
using System.Collections.Generic;
using System.Text;

namespace Sport
{
    class Zwmmer
    {
        private string spelerNaam;

        public string SpelerNaam
        {
            get { return spelerNaam; }
            set { spelerNaam = value; }
        }

        private string club;

        public string Club
        {
            get { return club; }
            set { club = value; }
        }

        private int reeks;

        public int Reeks
        {
            get { return reeks; }
            set { reeks = value; }
        }
        private int baanNr;

        public int BaanNr
        {
            get { return baanNr; }
            set { baanNr = value; }
        }

        public void ZwemBaan()
        {
            Console.WriteLine($"{SpelerNaam} zwemt een baan");
        }
        public void KeerPunt()
        {
            Console.WriteLine($"{SpelerNaam} maakt een keer punt");

        }
        public void KomtAaan()
        {
            Console.WriteLine($"{SpelerNaam} komt aan");
        }

        public void StelIn(string naam , string zwemclub, int reeksNr, int baan)
        {
            SpelerNaam = naam;
            Club = zwemclub;
            Reeks = reeksNr;
            BaanNr = baan;
        }

    }
}
