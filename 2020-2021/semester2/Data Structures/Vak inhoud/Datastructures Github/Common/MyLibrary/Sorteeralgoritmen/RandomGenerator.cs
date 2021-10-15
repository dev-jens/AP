using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Sorteeralgoritmen
{
    public class RandomGenerator
    {
        private readonly int amount;
        private readonly int min;
        private readonly int max;
        private readonly bool unique;

        public RandomGenerator(int Amount = 10, int Min = 0, int Max = 100, bool Unique = false)
        {
            amount = Amount;
            min = Min == 0? 1: Min;
            max = Max;
            unique = Unique;
        }

        public int[] GenerateNumbers()
        {
            var list = new int[amount];
            var rnd = new Random();
            int i = 0;
            int temp = 0;

            if (unique)
            {
                if (amount > max - min)
                    throw new Exception($"it is not possible to generate {amount} unique numbers between {min} and {max}");
            }

            while(i < amount)
            {
                do
                {
                    temp = rnd.Next(min, max);
                }
                while (unique && list.Contains(temp));

                list[i] = temp;
                i++;
            }
            return list;
        }
    }
}
