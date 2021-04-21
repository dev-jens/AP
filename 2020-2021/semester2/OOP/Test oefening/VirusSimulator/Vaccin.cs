using System;
using System.Collections.Generic;
using System.Text;

namespace VirusSimulator
{
    class Vaccin
    {
        public string Naam { get; private set; }

        public Vaccin(string naamVaccin)
        {
            Naam = naamVaccin; 
        }
        private int oplossing = -1;

        public int Oplossing
        {
            get { return oplossing; }
            set 
            { 
                if(value >= -1) 
                    oplossing = value; 
            }
        }

        static Random gen = new Random();

        public int TryKillcode()
        {
           
            if (Oplossing != -1)
            {
                return Oplossing;
            }
            
            return gen.Next(1, 101);
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Naam Vaccin: {Naam}\t Oplossing: {Oplossing}");
        }

        static public Vaccin DupliceerVaccin(Vaccin kop)
        {
            Vaccin vac = new Vaccin($"KOPIE{kop.Naam}");
            vac.Oplossing = kop.Oplossing;
            return vac;
        }

    }
}
