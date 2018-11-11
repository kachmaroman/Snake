using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        protected List<Point> _points;

        protected internal virtual void Draw()
        {
            foreach (var point in _points)
            {
                point.Draw();
            }
        }

        protected internal bool IsHit(Point point)
        {
            foreach (var p in _points)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }
    }
}