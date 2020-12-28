using System;

namespace pong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            bool gameOver = false;
            int balX = 5;
            int balY = 10;
            int vX = 1;
            int vY = 1;

            const int paddleLocationX = 5;
            int paddleLocationY = 10;


            while (!gameOver)
            {
                // input verwerken
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo invoer = Console.ReadKey();
                    if (invoer.Key == ConsoleKey.UpArrow)
                        paddleLocationY++;
                    else if (invoer.Key == ConsoleKey.DownArrow)
                        paddleLocationY--;
   
                }
                //update
                if (balX + vX >= Console.WindowWidth || balX + vX < 0)
                {
                    vX = -vX;
                }

                if (balY + vY >= Console.WindowHeight || balY + vY < 0)
                {
                    vY = -vY;
                }

                balX = balX + vX;

                balY = balY + vY;
                //renderen
                Console.SetCursorPosition(balX, balY);
                Console.Write("0");

                Console.SetCursorPosition(paddleLocationX, paddleLocationY);
                Console.Write("|");


                //wait
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }   
        }
    }
}
