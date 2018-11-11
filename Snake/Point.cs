using System;

namespace Snake
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Sym { get; set; }

        public Point()
        {
            
        }
        
        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Sym = sym;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
            Sym = point.Sym;
        }

        protected internal void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }

        protected internal void Clear()
        {
            Sym = '\0';
            Draw();
        }

        protected internal bool IsHit(Point point)
        {
            return X == point.X && Y == point.Y;
        }

        protected internal bool IsTail(Point point)
        {
            return X == point.X || Y == point.Y;
        }

        protected internal void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Y -= offset;
                    break;
                case Direction.Down:
                    Y += offset;
                    break;
                case Direction.Left:
                    X -= offset;
                    break;
                case Direction.Right:
                    X += offset;
                    break;
            }
        }
    }
}