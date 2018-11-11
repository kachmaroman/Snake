using System;
using System.Collections.Generic;

namespace Snake
{
    public class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            _points = new List<Point>();

            for (int i = xLeft; i < xRight; i++)
            {
                _points.Add(new Point(i, y, sym));
            }
        }

        protected internal override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Draw();
        }
    }
}