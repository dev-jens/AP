using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheek
{
    class Bibboek
    {
        public string NaamLener { get; set; }
        public DateTime DatumVandaag { get; private set; } = DateTime.Today;

        public DateTime inleverDate 
        {
            get 
            {
                return DatumVandaag.AddDays(14);
            }
        }

    }
}
