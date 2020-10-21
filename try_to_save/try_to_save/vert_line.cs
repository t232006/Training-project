using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace try_to_save
{
    class vert_line: figure
    {
        public vert_line(int y1, int y2, int x, char sym)
        {
            Cont = new List<Point>();
            for (int i = y1; i < y2; i++)
            {
                Point p = new Point(x, i, sym);
                Cont.Add(p);
            }
        }
    }
}
