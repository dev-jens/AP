using System;
using System.Collections.Generic;
using System.Text;

namespace OOPQuest.Game_Klassen
{
    enum HeroType {babarian, Paladin, Archer, Wizard }

    class Held
    {
        public string Name { get; set; }

        private double health;

        public double Health   
        {
            get { return health; }
            set {
                if (value>=0 && value<=100)
                {
                    health = value;
                }
                
            }
        }


        private double attack;

        public double Attack
        {
            get { return attack; }
            set { if(value>= 0) attack = value; }
        }

        private double defense;

        public double Defense
        {
            get { return defense; }
            set { if (value >= 0)   defense = value; }
        }

        public int Xp { get; set; }

    }
}
