using System;

namespace VirusSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LEN = 3;
            Virus virus = new Virus();

            Vaccin[] vaccins = new Vaccin[LEN];
            for (int i = 0; i < vaccins.Length; i++)
            {
                vaccins[i] = new Vaccin($"vacin2020V{i+1}");
            }
         
            int j = 0;

            bool werkendeVaccinOfNiet = virus.TryVaccin(vaccins[j% LEN]);
            while (!werkendeVaccinOfNiet && virus.DoomCountDown > 0)
            {
                werkendeVaccinOfNiet = virus.TryVaccin(vaccins[j% LEN]);
                if (!werkendeVaccinOfNiet)
                    j++;
            }
            if (werkendeVaccinOfNiet)
            {
                Vaccin werkende = Vaccin.DupliceerVaccin(vaccins[j%LEN]);
                werkende.ToonInfo();
            }
            else
            {
                Console.WriteLine("geen werkend vacin gevonden");
            }
        }
    }
}
