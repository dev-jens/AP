using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_the_Gathering
{
    enum Manatype {Water,Bos,Zon,Vuur,Dood }
    class LandKaart
    {
        public string LandName { get; private set; }
        public Manatype LandManaType { get; private set; }
        public LandKaart(string landName, Manatype Landtype)
        {
            LandName = landName;
            LandManaType = Landtype;
        }

        public void ToonKaart()
        {
            string message = $"*******************************************************" +
                             $"{LandName} ({LandManaType} mana)" +
                             $"*******************************************************";
            Console.WriteLine(message);
        }


        public static bool CastTest(List<LandKaart> landKaarten, CreateCreature creatureKaart)
        {
            Manatype coloredTypeNeeded = creatureKaart.CreatureCastingCost.ColoredTypeNeeded;
            int amountColoredTypeNeeded = creatureKaart.CreatureCastingCost.AmoundColoredTypeNeeded;
            int amountUncoloredTypeNeeded = creatureKaart.CreatureCastingCost.AMoundUnColoredTypeNeeded;

            int amountColoredType = 0;
            int amountOthers = 0;
            for (int i = 0; i < landKaarten.Count; i++)
            {
                if (landKaarten[i].LandManaType == coloredTypeNeeded)
                    amountColoredType++;
                else
                    amountOthers++;
            }

            if (amountColoredType >= amountColoredTypeNeeded && (amountOthers + amountColoredType - amountColoredTypeNeeded) >= amountUncoloredTypeNeeded)
                return true;
            return false;
        }
    }
}
