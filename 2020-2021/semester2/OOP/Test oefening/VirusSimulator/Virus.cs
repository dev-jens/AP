using System;
using System.Collections.Generic;
using System.Text;

namespace VirusSimulator
{
    class Virus
    {
        public string Naam { get; private set; }
        private int doomCountDown =999;

        public int DoomCountDown
        {
            get { return doomCountDown; }
            private set 
            { 
                if(value >=0)
                    doomCountDown = value;
                else
                    Console.WriteLine($"Game Over {Naam}");
            }
        }

        public Virus() 
        {
            DoomCountDown = r.Next(10, 20);
            killcode = r.Next(0, 100);
            for (int i = 0; i < 3; i++)
            {
                char letter = (char)r.Next('a', 'z' + 1);
                Naam += letter;
            }
             Naam += r.Next(1, 100);
            
        }

        private int killcode;

        static Random r = new Random();

        public bool TryVaccin(Vaccin vaccin) 
        {
            if (vaccin.TryKillcode() == killcode)
            {
                vaccin.Oplossing = killcode;
                return true;
            }
            else
            {
                DoomCountDown--;
                return false;
            }

           
        }

    }
}
