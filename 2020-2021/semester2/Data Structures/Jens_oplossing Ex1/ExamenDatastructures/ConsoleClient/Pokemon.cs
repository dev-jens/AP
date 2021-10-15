
using System;

namespace ConsoleClient
{
    public class Pokemon : IComparable<Pokemon>
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        // sorteer op naam in de opgave staat dat dit moet gebeuren door de klas zelf
        public int CompareTo(Pokemon other)
        {
            if (this.Name.CompareTo(other.Name) > 0)
                return 1;
            if (this.Name.CompareTo(other.Name) < 0)
                return -1;

            return 0;
        }

        public override string ToString()
        {
            return $"{Name}, my height is {Height} and Weight is {Weight}";
        }
    }
}
