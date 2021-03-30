using System;

namespace Baeten_jens_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Container graanContainer = new Container("basf","graan",30);
            Container waterContainer = new Container("basf","water",30);
           
            graanContainer.VoegContainerToe(waterContainer);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Scanner.ScanContainer(graanContainer));
                graanContainer.Gewicht += 10;
               
            }
        
        }
    }
}
