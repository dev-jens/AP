using System;
using System.Collections.Generic;
using System.Text;

namespace StudentKlasse
{
    public enum Klassen { IT1, IT2, IT3, IT4}
    class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen klas { get; set; }
        public int PuntCom { get; set; }
        public int PuntProg { get; set; }
        public int PuntWeb { get; set; }
        
        public double BerekenTotaalCijfer()
        {
            return (PuntProg + PuntWeb + PuntCom)/3.0;
        }
        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, {Leeftijd} jaar");
            Console.WriteLine($"Klas : {klas}");

            Console.WriteLine("Cijferrapport:");
            Console.WriteLine("**********");
            Console.WriteLine($"Communicatie: {PuntCom}"); 
            Console.WriteLine($"Prog Principles: {PuntProg}"); 
            Console.WriteLine($"Web tech :{PuntWeb}");  
            Console.WriteLine($"Gemiddelde: {BerekenTotaalCijfer():0.0} ");  
        }
    }
}
