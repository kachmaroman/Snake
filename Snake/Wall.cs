using System;
using System.Collections.Generic;

namespace Snake
{
    public class Wall : Figure
    {
        protected internal List<Figure> walls;
        
        public Wall(int width, int height, char sym)
        {
            walls = new List<Figure>();
            
            HorizontalLine upine = new HorizontalLine(1, width - 1, 0, sym);
            HorizontalLine downLine = new HorizontalLine(1, width - 1, height - 1, sym);
            VerticalLine  leftLine = new VerticalLine(0, height - 1, 1, sym);
            VerticalLine rightLine = new VerticalLine(0, height - 1, width - 1, sym);
            
            walls.Add(upine);
            walls.Add(downLine);
            walls.Add(leftLine);
            walls.Add(rightLine);
            
        }

        protected internal override void Draw()
        {
            foreach (var figure in walls)
            {
                figure.Draw();
            }
        }
    }
}