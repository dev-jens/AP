using System;
using System.Diagnostics;
namespace Pong
{
    class Program
    {
        static int HORIZONTAL_SIZE = 150;
        static int VERTICAL_SIZE = 40;

        static int leftScore = 0;
        static int rightScore = 0;

        static int lastBallPositionX = 3;
        static int lastBallPositionY = 3;
        static double ballAngle = 0;
        static double ballSpeed = 0.05;

        static int leftPlatformPositionY = VERTICAL_SIZE / 2;
        static int rightPlatformPositionY = VERTICAL_SIZE / 2;

        static bool startPos = true;

        static double lastBallDrawTime = 0;
        static double lastPlatformTime = 0;

        static Random randomGen = new Random();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            Console.WindowWidth = HORIZONTAL_SIZE + 1;
            Console.WindowHeight = VERTICAL_SIZE + 5;

            Stopwatch ballTimer = new Stopwatch();
            Stopwatch platformTimer = new Stopwatch();

            ballTimer.Start();
            platformTimer.Start();

            DrawRightPlatform();
            DrawLeftPlatform();

            Console.SetCursorPosition(HORIZONTAL_SIZE - 4, VERTICAL_SIZE + 2);
            Console.WriteLine(rightScore);

            Console.SetCursorPosition(4, VERTICAL_SIZE + 2);
            Console.WriteLine(leftScore);

            DrawBox();

            while (true)
            {
                if (ballTimer.Elapsed.TotalSeconds > lastBallDrawTime)
                {
                    lastBallDrawTime = ballTimer.Elapsed.TotalSeconds + ballSpeed;
                    DrawBall();
                }

                if (platformTimer.Elapsed.TotalSeconds > lastPlatformTime)
                {
                    lastPlatformTime = platformTimer.Elapsed.TotalSeconds + ballSpeed;
                    CheckInput();
                }
            }
        }

        static void DrawBall()
        {
            int newBallPositionX;
            int newBallPositionY;

            if (startPos)
            {
                Console.SetCursorPosition(lastBallPositionX, lastBallPositionY);
                Console.Write(" ");

                newBallPositionX = HORIZONTAL_SIZE / 2;
                newBallPositionY = VERTICAL_SIZE / 2;

                int randomNumber = randomGen.Next(0, 2);
                ballAngle = randomNumber == 0 ? 0 : 180;

                Console.SetCursorPosition(newBallPositionX, newBallPositionY);
                Console.Write(@"●");

                startPos = false;
            }
            else
            {
                Console.SetCursorPosition(lastBallPositionX, lastBallPositionY);
                Console.Write(" ");

                DrawBox(); // bug door console idk dit fixt het??

                ballAngle = CollisionDetection();

                newBallPositionX = lastBallPositionX + (int)Math.Round(Math.Cos(ballAngle * (Math.PI / 180)));
                newBallPositionY = lastBallPositionY + (int)Math.Round(Math.Sin(ballAngle * (Math.PI / 180)));

                Console.SetCursorPosition(newBallPositionX, newBallPositionY);
                Console.Write(@"●");
            }

            lastBallPositionX = newBallPositionX;
            lastBallPositionY = newBallPositionY;
        }

        static void CheckInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (rightPlatformPositionY + 3 > 7)
                        {
                            ClearRightPlatform();
                            rightPlatformPositionY -= 1;
                            DrawRightPlatform();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (rightPlatformPositionY - 3 < 33)
                        {
                            ClearRightPlatform();
                            rightPlatformPositionY += 1;
                            DrawRightPlatform();
                        }
                        break;
                    case ConsoleKey.W:
                        if (leftPlatformPositionY + 3 > 7)
                        {
                            ClearLeftPlatform();
                            leftPlatformPositionY -= 1;
                            DrawLeftPlatform();
                        }
                        break;
                    case ConsoleKey.S:
                        if (leftPlatformPositionY - 3 < 33)
                        {
                            ClearLeftPlatform();
                            leftPlatformPositionY += 1;
                            DrawLeftPlatform();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        static void DrawLeftPlatform()
        {
            for (int i = -3; i <= 3; i++)
            {
                Console.SetCursorPosition(2, leftPlatformPositionY + i);
                Console.Write(@"█");

            }
        }

        static void DrawRightPlatform()
        {
            for (int i = -3; i <= 3; i++)
            {
                Console.SetCursorPosition(HORIZONTAL_SIZE - 2, rightPlatformPositionY + i);
                Console.Write(@"█");
            }
        }

        static void ClearLeftPlatform()
        {
            for (int i = -3; i <= 3; i++)
            {
                Console.SetCursorPosition(2, leftPlatformPositionY + i);
                Console.Write(" ");
            }
        }

        static void ClearRightPlatform()
        {
            for (int i = -3; i <= 3; i++)
            {
                Console.SetCursorPosition(HORIZONTAL_SIZE - 2, rightPlatformPositionY + i);
                Console.Write(" ");
            }
        }

        static double CollisionDetection()
        {
            double newAngle = ballAngle;

            if (lastBallPositionX == 1)
            {
                startPos = true;

                rightScore++;

                Console.SetCursorPosition(HORIZONTAL_SIZE - 4, VERTICAL_SIZE + 2);
                Console.WriteLine(rightScore);
            }

            if (lastBallPositionX == HORIZONTAL_SIZE - 1)
            {
                startPos = true;

                leftScore++;

                Console.SetCursorPosition(4, VERTICAL_SIZE + 2);
                Console.WriteLine(leftScore);
            }

            if (lastBallPositionY == 1 || lastBallPositionY == VERTICAL_SIZE - 1)
            {
                newAngle *= -1;
            }

            for (int i = -3; i <= 3; i++)
            {
                if ((lastBallPositionX == 4 && lastBallPositionY == leftPlatformPositionY + i) || (lastBallPositionX == HORIZONTAL_SIZE - 4 && lastBallPositionY == rightPlatformPositionY + i))
                {
                    if (newAngle == 0 || newAngle == 180)
                    {
                        newAngle = 45;
                    }

                    newAngle = 180 - newAngle;
                }
            }

            return newAngle;
        }

        static void DrawBox()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(@"╔");

            Console.SetCursorPosition(HORIZONTAL_SIZE, 0);
            Console.Write(@"╗");

            Console.SetCursorPosition(HORIZONTAL_SIZE, VERTICAL_SIZE);
            Console.Write(@"╝");

            Console.SetCursorPosition(0, VERTICAL_SIZE);
            Console.Write(@"╚");

            for (int i = 1; i < HORIZONTAL_SIZE; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write(@"═");
            }

            for (int i = 1; i < VERTICAL_SIZE; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(@"║");
            }

            for (int i = 1; i < HORIZONTAL_SIZE; i++)
            {
                Console.SetCursorPosition(i, VERTICAL_SIZE);
                Console.Write(@"═");
            }

            for (int i = 1; i < VERTICAL_SIZE; i++)
            {
                Console.SetCursorPosition(HORIZONTAL_SIZE, i);
                Console.Write(@"║");
            }

            Console.SetCursorPosition(3, 3);
        }
    }
}
