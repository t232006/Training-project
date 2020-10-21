using System;
using System.Collections.Generic;
using System.Text;

namespace try_to_save
{
    class hor_line
    {
        List<Point> Cont = new List<Point>();
        public hor_line(int x1, int x2, int y, char sym)
        {

            for (int i = x1; i < x2; i++)
            {
                Point p = new Point(y, i, sym);
                Cont.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point i in Cont)
            {
                i.Draw();
            }
        }
    }
}
