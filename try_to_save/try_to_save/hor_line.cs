using System;
using System.Collections.Generic;
using System.Text;

namespace try_to_save
{
    class hor_line: figure
    {
        public hor_line(int x1, int x2, int y, char sym)
        {
            Cont = new List<Point>();
            for (int i = x1; i < x2; i++)
            {
                Point p = new Point(i, y, sym);
                Cont.Add(p);
            }
        }
    }
}
