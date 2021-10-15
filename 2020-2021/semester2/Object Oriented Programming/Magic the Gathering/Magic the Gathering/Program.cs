using System;
using System.Collections.Generic;
namespace Magic_the_Gathering
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCreature creature1 = new CreateCreature("Mahamori Djinn", new CastingCost(Manatype.Water, 2, 4), "Flying", "Of royal blood amoung the spirits of the air...", 5, 6);
            CreateCreature creature2 = new CreateCreature("KinderCatch", new CastingCost(Manatype.Bos, 3, 3), "", "In the forest villages of Kessig...", 6, 6);
            CreateCreature creature3 = new CreateCreature("Mountain Goat", new CastingCost(Manatype.Vuur, 1, 0), "Mountainwalk", "Folklore has it that to capture a mountain goat is a sign of devine blessing", 1, 1);

            int input = 0;

            List<LandKaart> landKaarten = new List<LandKaart>();
            for (int i = 0; i < Enum.GetValues(typeof(Manatype)).Length; i++)
            {
                Manatype manaType = (Manatype)i;
                string name = manaType.ToString();

                Console.Write($"Aantal {(Manatype)i}? \n" + ">>>");
                input = int.Parse(Console.ReadLine()); // We gaan ervan uit dat de gebruiker een input geeft die naar een int geparsed kan worden
                for (int j = 0; j < input; j++)
                {
                    landKaarten.Add(new LandKaart(name, manaType));
                }
            }
            Console.Clear();
            creature1.ToonKaart();
            creature2.ToonKaart();
            creature3.ToonKaart();
            Console.WriteLine("Kies 1 van bovenstaande creature kaarten (input:1-2-3)");

            input = int.Parse(Console.ReadLine()); // We gaan ervan uit dat de gebruiker de juiste input geefts
            CreateCreature creatureToTest = null;
            switch (input)
            {
                case 1:
                    creatureToTest = creature1;
                    break;
                case 2:
                    creatureToTest = creature2;
                    break;
                case 3:
                    creatureToTest = creature3;
                    break;
            }
            bool canBeCreated = LandKaart.CastTest(landKaarten, creatureToTest);
            if (canBeCreated)
                Console.WriteLine("Creature kan gemaakt worden");
            else
                Console.WriteLine("Creature kan niet gemaakt worden");

            Console.ReadKey();


        }
    }
}
