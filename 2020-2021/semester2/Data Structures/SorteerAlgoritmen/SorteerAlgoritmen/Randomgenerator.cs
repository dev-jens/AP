using System;
using System.Collections.Generic;
using System.Text;

namespace SorteerAlgoritmen
{
    class Randomgenerator
    {
        public int Amount { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public bool Unique { get; set; }

        public Randomgenerator(int _Amount, int _Max, int _Min) //,bool _Unique)
        {
            Amount = _Amount;
            Max = _Max;
            Min = _Min;
            //Unique = _Unique;
        }

        public int[] Generate()
        {
            Random r = new Random();
            int[] lijstGet = new int[Amount];

            for (int i = 0; i < lijstGet.Length; i++)
            {
                lijstGet[i] = r.Next(Min, Max);
            }

            return lijstGet;

        }

    }
}
