using System;
using System.Collections.Generic;
using System.Text;

namespace Politiek
{
    class Land
    {
        private President president;
        private Minister eersteMinister;
        private List<Minister> MinsterLijst = new List<Minister>(4);
        
        public void MaakRegering(President presi , List<Minister> minlijst)
        {
            if (president == null)
            {
                president = presi;
                eersteMinister = minlijst[0];
                for (int i = 1; i < minlijst.Count; i++)
                {
                    MinsterLijst[i] = minlijst[i];
                }
            }
            else
            {
                Console.WriteLine("we all ready maak regering");
            }
          
        }

        public void Jaarverder()
        {
            if (president  != null)
            {
                president.Jaarverder();
                if (president.teller <= 0 )
                {
                    Console.WriteLine("reegring ophoepelen");
                    president = null;
                    eersteMinister = null;
                    MinsterLijst.Clear();
                }
            }
        }

    }
}
