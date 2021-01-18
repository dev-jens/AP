using System;


namespace Passwoord_Gen
{
    class Program
    {
        static string PasswoordGen(int lenghtpasswd) 
        {
            Random r = new Random();
            string password =  "";

            for (int i = 0; i < lenghtpasswd ; i++)
            {
                if (i < lenghtpasswd - 2)
                {
                    int alfabet = r.Next(97, 123);
                    password += (char)alfabet;
                }
                else
                {
                    int numbers = r.Next(0, 10);
                    password += numbers;
                }
                
            }

            return password;
        }



        static void Main(string[] args)
        {
            Console.Write("geef de lengte van een passwd!: ");
            int lengte = int.Parse(Console.ReadLine());
            string password = PasswoordGen(lengte);
            Console.WriteLine($"dit is jou password {password}");
        }
    }
}
