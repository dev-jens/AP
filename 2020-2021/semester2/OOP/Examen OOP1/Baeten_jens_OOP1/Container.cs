using System;
using System.Collections.Generic;
using System.Text;

namespace Baeten_jens_OOP1
{
    class Container
    {   // 2keer auto prop Beschrijving aangenomen dat dit een typ fout is
        public string Firma { get; private set; }
        public string Beschrijving { get; private set; }
        public DateTime LaatstAangepast { get; private set; }
        public DateTime GemaaktOp  { get; private set; }

        private int gewicht;

        public int Gewicht
        {
            get { return gewicht; }
            set 
            {
                if (value >= 0 && value <= 100)
                {
                    gewicht = value;
                }
                else
                {
                    Console.WriteLine("fout gewicht. Ingesteld op 100");
                    gewicht = 100;
                }
                LaatstAangepast = LaatstAangepast.AddDays(1);
            }
        }

        public Container(string firmin, string beschrijvingin,int gewichtin)
        {
            Firma = firmin;
            Beschrijving = beschrijvingin;
            Gewicht = gewichtin;
            GemaaktOp = DateTime.Now;
            LaatstAangepast = DateTime.Now;
        }

        public void Clear()
        {
            Beschrijving = "";
            Gewicht = 0;
        }
        public TimeSpan InWerking()
        {
            return LaatstAangepast - GemaaktOp;
        }

        public void VoegContainerToe(Container newContainer)
        {
            if (Firma == newContainer.Firma)
            {
                int somGewicht = Gewicht + newContainer.Gewicht;
                if (somGewicht < 100)
                {
                    Gewicht += newContainer.Gewicht;
                    Beschrijving += $" en {newContainer.Beschrijving}";
                    newContainer.Clear();
                }
                else
                {
                    Console.WriteLine("Kan Container noet toeveogen. Dit zou gewicht boven de 100 brengen");
                    return;
                }

            }
            else
            {
                Console.WriteLine("Containers zijn niet van zelfde firma. kan niet samenvoegen");
                return;
            }
        }

    }
}
