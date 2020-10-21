using System;
using System.Collections.Generic;
using System.Text;

namespace try_to_save
{
    class figure
    {
        protected List<Point> Cont;
        public void Draw()
        {
            foreach (Point i in Cont)
            {
                i.Draw();
            }
        }
    }
}
