using System;

namespace BAsics
{
    class Program
    {

        static void MyIntro(string naam , int age , string straat) 
        {
            Console.WriteLine($"ik ben {naam} en ik ben {age} jaar ik woon {straat} speciaal");
        }

        static void Main(string[] args)
        {
            MyIntro("jens",20,"kut");

            

        }
    }
}
