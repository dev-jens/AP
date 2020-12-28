using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the multitool application");
            Console.Write("Press 1-Calculator, 2-Passwd tester, 3-Recylage(BMI), 4-Computersolver: ");
            int keuze = int.Parse(Console.ReadLine());

            switch (keuze)
            {
                case 1:
                    Console.Write("give a number: ");
                    int number1 = int.Parse(Console.ReadLine());
                    Console.Write("give a second number: ");
                    int number2 = int.Parse(Console.ReadLine());

                    double result = 0;

                    Console.Write("choose an operator (+, -, *, / , %): ");
                    char inputOpperator = char.Parse(Console.ReadLine());

                    if (inputOpperator == '+')
                    {
                        result = number1 + number2;
                    }
                    else if (inputOpperator == '-')
                    {
                        result = number1 - number2;
                    }
                    else if (inputOpperator == '*')
                    {
                        result = number1 * number2;
                    }
                    else if (inputOpperator == '/')
                    {
                        result = number1 / number2;
                    }
                    else if (inputOpperator == '%')
                    {
                        result = number1 % number2;
                    }

                    if (result < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;  
                    }

                    Console.WriteLine($"De uitkomst is: {result}");
                    Console.ResetColor();

                    break;
                case 2:
                    const string PASSWORD = "TrumpSux";
                    Console.Write("Wat is je password: ");
                    string password = Console.ReadLine();

                    if (password == PASSWORD)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Toegelaten");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Verboden");
                    }
                    Console.ResetColor();

                    break;
                case 3:
                    Console.Write("Wat is jou gewicht in kg: ");
                    double gewicht = double.Parse(Console.ReadLine());

                    Console.Write("Wat is jou lengte in meter (bv: 1.75)");
                    double lengte = double.Parse(Console.ReadLine());

                    double bmi = Math.Round(gewicht / Math.Pow(lengte, 2), 2);

                    Console.WriteLine($"Je Bmi is {bmi} dit betekent dat:");

                    if (bmi < 18.5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"je een ondergewicht hebt");

                    }
                    else if (bmi < 24.9)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" je een normaal bmi hebt");

                    }
                    else if (bmi < 29.9)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("je een overgewicht hebt. Je loopt niet echt een risico, maar je mag niet dikker worden.");

                    }
                    else if (bmi < 39.9)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("je overgewicht hebt(obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg  ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(" je ernstige zwaarlijvigheid bent. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).");

                    }
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Write("does your computer trun on ?(Y/N):  ");
                    char pcTurnOn = char.Parse(Console.ReadLine().ToUpper());

                    if (pcTurnOn == 'Y')
                    {
                        Console.Write("are there any error messages? (Y/N)");
                        char errorMessages = char.Parse(Console.ReadLine().ToUpper());

                        if (errorMessages == 'Y')
                        {
                            Console.WriteLine("Perform a search for the error message");
                        }
                        else
                        {
                            Console.WriteLine("Computer is fine");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Is the computer power light on? ");
                        char powerLight = char.Parse(Console.ReadLine().ToUpper());

                        if (powerLight =='Y')
                        {
                            Console.WriteLine("Turn the computer monitor on");
                        }
                        else
                        {
                            Console.WriteLine("Check thecomputer power cord");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Wrong input bruv");
                    break;
            }       
        }
    }
}
