
namespace ConsoleClient
{
    public class Pokemon  
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"{Name}, my height is {Height} and Weight is {Weight}";
        }
        public int CompareName(Pokemon x, )
        {
            if (this.Name[0].CompareTo(x) > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }
        public int CompareHeight(Pokemon x)
        {
            if (this.Height.CompareTo(x) > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }


    }
}
