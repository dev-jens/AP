using System;

namespace string_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string Reverse(string text) 
            {
                // exit
                if (text.Length <= 0)
                {
                    return text;
                }
                return Reverse(text.Substring(1)) + text[0];
            }

            Console.WriteLine(Reverse("jens"));
        }
    }
}
