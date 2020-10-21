using System;
using System.Collections.Generic;
using System.Text;

namespace try_to_save
{
    class Point
    {
        public Point(int x1, int y1, char sym1)
        {
            x = x1; y = y1; sym = sym1;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        int x;
        int y;
        char sym;
        public void Draw() 
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
        public void move(int offset, Direction direction)
        {
            if (direction == Direction.UP)
                y -= offset;
            if (direction == Direction.DOWN)
                y += offset;
            if (direction == Direction.LEFT)
                x -= offset;
            else x += offset;
            Draw();
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

    }
}
