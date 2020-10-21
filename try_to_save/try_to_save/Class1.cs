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
        int x;
        int y;
        char sym;
        public void Draw() 
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
