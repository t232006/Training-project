using System;
using System.Collections.Generic;
using System.Text;

namespace try_to_save
{
    class Snake : figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            List<Point> Cont = new List<Point>();
            for (int i = 1; i <= length; i++)
            {
                Point p = new Point(tail);
                p.move(i, direction);
                Cont.Add(p);
            }
        }
        

    }
}
