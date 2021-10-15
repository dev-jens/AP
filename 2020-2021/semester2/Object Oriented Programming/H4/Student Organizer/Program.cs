using System;
using System.Collections.Generic;

namespace Student_Organizer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentenLijst = new List<Student>();
            int input = 0;
            do
            {
                Console.WriteLine("wat wil je doen? 1: toevegen , 2 tonen, 3: stopppen");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        //toevoegen
                        Console.WriteLine("Wat is je naam");
                        string naam = Console.ReadLine();
                        Console.WriteLine("Wat is je Leeftijd");
                        int leeftijd = int.Parse(Console.ReadLine());
                        Console.WriteLine("wat is je klas 0:EA1, 1:EA2, 2:EA3, 3:EA4");
                        int klas = int.Parse(Console.ReadLine());

                        Console.WriteLine("Wat is je Puntcom");
                        int puntCom = int.Parse(Console.ReadLine());
                        Console.WriteLine("Wat is je PuntPP");
                        int puntPP = int.Parse(Console.ReadLine());
                        Console.WriteLine("Wat is je PuntWeb");
                        int puntWeb = int.Parse(Console.ReadLine());

                        StudentenLijst.Add(new Student() {Naam =naam, Leeftijd = leeftijd, Klas= (Klassen)klas, PuntenCommunicatie = puntCom, PuntenProgrammingPrinciples= puntPP, PuntenWebTech=puntWeb });

                        break;
                    case 2:
                        foreach (var student in StudentenLijst)
                        {
                            student.GeefOverzicht();
                        }

                        break;
                    default:
                        input = 3;
                        break;
                }


            } while (input != 3);


        }




        enum Klassen { EA1, EA2, EA3, EA4 }

        class Student
        {
            public string Naam { get; set; }
            public int Leeftijd { get; set; }
            public Klassen Klas { get; set; }

            public int PuntenCommunicatie { get; set; }
            public int PuntenProgrammingPrinciples { get; set; }
            public int PuntenWebTech { get; set; }

            public double BerekenTotaalCijfer()
            {
                return (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0;
            }

            public void GeefOverzicht()
            {
                Console.WriteLine($"{Naam}, {Leeftijd} jaar");
                Console.WriteLine($"Klas: {Klas}");
                Console.WriteLine();
                Console.WriteLine("Cijferrapport");
                Console.WriteLine("*************");
                Console.WriteLine($"Communicatie:\t\t{PuntenCommunicatie}");
                Console.WriteLine($"Programming Principles:\t{PuntenProgrammingPrinciples}");
                Console.WriteLine($"Web Technology:\t\t{PuntenWebTech}");
                Console.WriteLine($"Gemiddelde:\t\t{BerekenTotaalCijfer():0.0}");
            }
        }
    }
}
