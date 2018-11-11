using System;
using System.Linq;

namespace Snake
{
    public class Food
    {
        private int width;
        private int height;
        private char sym;
        private Snake snake;

        readonly Random _random = new Random();
        
        public Food(int width, int height, char sym, Snake snake)
        {
            this.width = width;
            this.height = height;
            this.snake = snake;
        }

        public Point Create()
        {
            int x = _random.Next(2, width - 2);
            int y = _random.Next(2, height - 2);

            Point food = new Point(x, y, sym);

            bool isTail = snake.GetSnake().Any(p => p.IsTail(food));
            
            while (isTail)
            {
                x = _random.Next(2, width - 2);
                y = _random.Next(2, height - 2);
                food = new Point(x, y, sym);

                isTail = snake.GetSnake().Any(p => p.IsTail(food));
            }

            return food;
        }
    }
}