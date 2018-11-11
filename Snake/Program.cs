using System;
using System.Threading;

namespace Snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {      
            Console.CursorVisible = false;
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            
            Wall wall = new Wall(Console.WindowWidth, Console.WindowHeight, '+');
            wall.Draw();

            Point tail = new Point(5, 10, '*');
            Snake snake = new Snake(tail, 5, Direction.Right);
            snake.OnHit += WriteGameOver;
            snake.Draw();
            
            Food foodCreator = new Food(Console.WindowWidth, Console.WindowHeight, '$', snake);
            Point food = foodCreator.Create();
            food.Draw();
            
            while (true)
            {
                snake.Run();

                if (snake.IsHitTail() || snake.IsHitWall(wall))
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.Create();
                    food.Draw();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    snake.Move(key);
                }

                Thread.Sleep(100);
            }

            Console.ReadKey();
        }

        static void WriteGameOver(object sender, HitEventArgs eventArgs)
        {
            int xOffset = (Console.WindowWidth / 2) - 17;
            int yOffset = (Console.WindowHeight / 2) - 5;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("G A M E    O V E R", xOffset + 5, yOffset++);
            yOffset += 1;
            Console.ForegroundColor = ConsoleColor.Green;
            WriteText($"Score: {eventArgs.Score}", xOffset + 10, yOffset++);
            yOffset += 1;
            Console.ForegroundColor = ConsoleColor.Cyan;
            WriteText("Author: Roman Kachmar", xOffset + 3, yOffset++);
            Console.ForegroundColor = ConsoleColor.Red;
            WriteText("============================", xOffset, yOffset++);
        }

        static void WriteText(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}