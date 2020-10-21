using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace try_to_save
{
    class Snake : figure
    {
        Direction direction;
        //Point tail;
        public Snake(Point tail, int length, Direction direct)
        {
            direction = direct;
            //tail = _tail;
            Cont = new List<Point>();
            for (int i = 1; i <= length; i++)
            {
                Point p = new Point(tail);
                p.move(i, direct);
                Cont.Add(p);
            }
        }
        public Point GetNextPoint()
        {
            Point p = Cont.Last();
            Point NewP = new Point(p);
            NewP.move(1, direction);
            return NewP;
        }
        public void move()
        {
            Point tail = Cont.First();
            Cont.Remove(tail);
            Point head = GetNextPoint();
            Cont.Add(head);

            tail.Clear();
            


        }

    }
}
