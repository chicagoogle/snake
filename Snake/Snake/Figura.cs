using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    abstract class Figura
    {
        protected List<Point> pList = new List<Point>();

        public void Drow()
        {
            foreach (Point item in pList)
            {
                item.Draw();
            }
        }
    }
}
