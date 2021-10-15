
namespace ConsoleClient
{
    public class Person 
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"{Name}, I am {Gender}. My height is {Height} and Weight is {Weight}";
        }
    }

    public enum Gender
    {
        Female,
        Male
    }
}
