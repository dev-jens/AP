using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_the_Gathering
{
    class CreateCreature
    {
        public string CreatureName { get; private set; }
        public CastingCost CreatureCastingCost { get; private set; }
        public string SpecialAbilities { get; private set; }
        public string FlavourText { get; private set; }
        private int attack;

        public int Attack
        {
            get { return attack; }
            set { if(value>=0) attack = value; }
        }
        private int defense;

        public int Defense
        {
            get { return defense; }
            set { if(value>=0)defense = value; }
        }

        public CreateCreature(string creatureName,CastingCost castcost, string Sp_abi,string flav,int atck , int def)
        {
            CreatureName = creatureName;
            CreatureCastingCost = castcost;
            SpecialAbilities = Sp_abi;
            FlavourText = flav;
            Attack = atck;
            Defense = def;
        }

        public void ChangeAttack(bool change) 
        {
            if (change)
            {
                Attack++;
            }
            else
                Attack--;
        }
        public void ToonKaart()
        {
            string mes = $"*******************************************************\n" +
                         $"{CreatureName} ({CreatureCastingCost.AMoundUnColoredTypeNeeded} kleurloos, {CreatureCastingCost.AmoundColoredTypeNeeded} {CreatureCastingCost.ColoredTypeNeeded} mana)\n" +
                         $"*******************************************************\n" +
                         $"\"{FlavourText}\"\n" +
                         $"-------------------------------------------------------\n" +
                         $"Abilities : {SpecialAbilities}\n" +
                         $"Attack : {Attack}\n" +
                         $"Defense: {Defense}\n" +
                         $"-------------------------------------------------------\n";

            Console.WriteLine(mes);
        }

    }
}
