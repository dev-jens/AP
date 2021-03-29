using System;

namespace StudentKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.klas = Klassen.IT2;
            student1.Leeftijd = 21;
            student1.Naam = "Joske Vermeulen";
            student1.PuntCom = 12;
            student1.PuntProg = 15;
            student1.PuntWeb = 13;

            student1.GeefOverzicht();
        }
    }
}
