using System;

namespace try_to_save
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 5, '#');
            p1.Draw();

            vert_line line = new vert_line(3, 17, 5, '^');
            line.Draw();

            Console.ReadKey();
        }
    }
}
