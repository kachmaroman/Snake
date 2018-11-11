using System;
using System.Collections.Generic;

namespace Snake
{
    public class VerticalLine : Figure    
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            _points = new List<Point>();

            for (int i = yUp; i < yDown; i++)
            {
                _points.Add(new Point(x, i, sym));
            }
        }

        protected internal override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Draw();
        }
    }
}