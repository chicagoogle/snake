﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figura
    {
        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            for (int y = yTop; y <= yBottom; y++)
                pList.Add(new Point(x, y, sym));
        }
    }
}
