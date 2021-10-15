using System;

namespace Ziekenhuis
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient joske = new Patient() { Naam ="jos" , AantalUur = 5};
            VerzekerdePatient felix = new VerzekerdePatient() { Naam = "felix", AantalUur = 5 };

            joske.ToonInfo();
            felix.ToonInfo();
        }
    }
}
