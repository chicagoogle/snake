using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorisontalLine
    {
        List<Point> p = new List<Point>();

        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            for (int x = xLeft; x <= xRight; x++)
            {
                p.Add(new Point(x, y, sym));
            }
        }

        public void Drow()
        {
            foreach (Point item in p)
            {
                item.Draw();
            }
        }
    }
}
