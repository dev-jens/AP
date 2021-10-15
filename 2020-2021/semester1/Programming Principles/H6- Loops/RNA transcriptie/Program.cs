using System;


namespace RNA_transcriptie
{
    class Program
    {
        static void Main(string[] args)
        {
            string DNA = "";
            string RNA = "";
            
            do
            {
                
                Console.Write("geef ene dna CGTA: ");
                DNA = Console.ReadLine().ToUpper();
       

                switch (DNA)
                {
                    case "C":
                        RNA += "G";
                        break;
                    case "G":
                        RNA += "C";
                        break;
                    case "T":
                        RNA += "A";
                        break;
                    case "A":
                        RNA += "T";
                        break;

                    default:
                        DNA = "Q";
                        RNA += "";
                        break;
                }
               

            } while (DNA != "Q");

            Console.WriteLine($"je krijgt  RNA string: {RNA}");
        }
    }
}
