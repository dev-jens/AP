using System;
using System.Collections.Generic;
using System.Text;

namespace Baeten_jens_OOP1
{
    class Scanner
    {
        public static string ScanContainer(Container ContainerTeScannen)
        {
            double Dagen = ContainerTeScannen.InWerking().TotalDays;
            if (Dagen >= 5)
            {
                return $"---CONTAINERREPORT [{ContainerTeScannen.Firma.ToUpper()}]---" +
                $"\n\t\t Lading: [{ContainerTeScannen.Beschrijving}]" +
                $"\n\t\t Gewicht [{ContainerTeScannen.Gewicht}] kg" +
                $"\n +++Deze container heeft verdacht veel gewichtsveranderingen ondergaan" +
                $"\n---------------------------------------------------";

            }
            else
            {
                return $"---CONTAINERREPORT [{ContainerTeScannen.Firma.ToUpper()}]---" +
                $"\n\t\t Lading: [{ContainerTeScannen.Beschrijving}]" +
                $"\n\t\t Gewicht [{ContainerTeScannen.Gewicht}] kg" +
                $"\n---------------------------------------------------";
            }
        }
    }
}
