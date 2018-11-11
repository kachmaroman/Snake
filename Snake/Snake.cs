using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class Snake : Figure
    {
        private int score;
        private Direction _direction;
        public event EventHandler<HitEventArgs> OnHit; 
        
        public Snake(Point tail, int length, Direction direction)
        {
            _points = new List<Point>();
            _direction = direction;

            for (int i = 0; i < length; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                _points.Add(point);
            }
        }

        protected internal override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Draw();
        }

        protected internal void Run()
        {
            Point tail = _points.First();
            _points.Remove(tail);

            Point head = GetNextPoint();
            _points.Add(head);
            
            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = _points.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);

            return nextPoint;
        }

        protected internal virtual bool IsHitTail()
        {
            Point head = _points.Last();
            
            foreach (var point in _points.TakeWhile(x => x != head))
            {
                if (head.IsHit(point))
                {
                    Clear();          
                    OnHitEvent();
                    
                    return true;
                }
            }

            return false;
        }

        protected internal bool IsHitWall(Wall wall)
        {
            Point head = _points.Last();
            bool ishit = wall.walls.Any(x => x.IsHit(head));

            if (ishit)
            {
                Clear();
                OnHitEvent();
            }

            return ishit;
        }

        private void Clear()
        {
            foreach (var point in _points)
            {
                point.Clear();
            }
            
            _points.Clear();
        }

        protected virtual void OnHitEvent()
        {
            OnHit?.Invoke(this, new HitEventArgs(score));
        }

        protected internal void Move(ConsoleKey key)
        {
            switch (key)
            {
                  case ConsoleKey.LeftArrow when _direction != Direction.Right: 
                      _direction = Direction.Left;
                      break;
                  case ConsoleKey.UpArrow when _direction != Direction.Down:
                      _direction = Direction.Up;
                      break;
                  case ConsoleKey.RightArrow when _direction != Direction.Left:
                      _direction = Direction.Right;
                      break;
                  case  ConsoleKey.DownArrow when _direction != Direction.Up:
                      _direction = Direction.Down;
                      break;
            }
        }

        public List<Point> GetSnake()
        {
            return _points;
        }

        public bool Eat(Point food)
        {
            Point head = _points.Last();
            bool isEaten = head.IsHit(food);

            if (isEaten)
            {
                score++;
                _points.Add(food);
            }

            return isEaten;
        }
    }
}