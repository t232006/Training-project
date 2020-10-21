using System;
using System.Threading;

namespace try_to_save
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 5, '#');
            /*p1.Draw();*/

            vert_line line1 = new vert_line(0, Console.WindowHeight, 0, '#');
            line1.Draw();
            vert_line line2 = new vert_line(0, Console.WindowHeight-1, Console.WindowWidth-1, '#');
            line2.Draw();
            hor_line line3 = new hor_line(0, Console.WindowWidth-1, Console.WindowHeight-1, '#');
            line3.Draw();
            hor_line line4 = new hor_line(0, Console.WindowWidth-1, 0, '#');
            line4.Draw();
            Snake s = new Snake(p1, 4, Direction.RIGHT);
            s.move();
            s.Draw();
            Thread.Sleep(900);
            s.move();
            s.Draw();
            Thread.Sleep(900);
            s.move();
            s.Draw();
            Thread.Sleep(900);
            s.move();
            s.Draw();
            Thread.Sleep(900);
            s.move();
            s.Draw();
            Thread.Sleep(900);






            Console.ReadKey();
        }
    }
}
