using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace try_to_save
{
    class vert_line
    {
        List<Point> Cont = new List<Point>();
        public vert_line(int y1, int y2, int x, char sym)
        {
            
            for (int i = y1; i < y2; i++)
            {
                Point p = new Point(x, i, sym);
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
