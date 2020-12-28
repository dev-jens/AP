using System;

namespace kill_death_ratio
{
    class Program
    {
        static void Main(string[] args)
        {
             double Kills = 50;
             double deaths = 3;
             double kdRatio = Kills / deaths;

             Console.WriteLine($"Mijn kill death ratio is {kdRatio}"); 
        }
    }
}
