using MyLibrary;
using System;
using System.ComponentModel;
using System.Linq;

namespace StringKeerOm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een string en ik keer deze om!");
            var text = Console.ReadLine();
            Console.WriteLine($"Het omgekeerde van {text} is {Reverse(text)}");

        }

        static string Reverse (string text)
        {
            if (text == null)           //defensive programming
                throw new Exception("text cannot be NULL");

            if (text.Length <= 1)       //base case is certainely 1 char, but 0 is also allowed
                return text;

            return Reverse(text.Substring(1)) + text[0];  //Reverse("WORD") => Reverse("ORD") + "W"
        }

       
    }
}
