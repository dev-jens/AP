using System;

namespace RNA_transcriptie
{
    class Program
    {
        static void Main(string[] args)
        {
            string rna = ""; 
            string dna = "";
            int lengte = 0;
            do
            {
                lengte++;
                Console.Write("geef nucleotide: ");
                string inputNucleo = Console.ReadLine().ToUpper();
                
                switch (inputNucleo)
                {
                    case "G":
                        rna += "C";
                       
                        break;
                    case "C":
                        rna += "G";
                        break;
                    case "A":
                        rna += "T";
                        break;
                    case "T":
                        rna += "A";
                        break;

                    default:
                        break;
                }
                dna += inputNucleo;

            } while (lengte != 12);
            Console.WriteLine("");
            Console.WriteLine(@$"Soort string            String    
DNA                     {dna}
RNA                     {rna}
");
            
        }   

    }
}
