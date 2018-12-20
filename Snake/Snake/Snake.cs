using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figura
    {
        private Direction direction;

        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;

            pList = new List<Point>();
            
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        public void Move()
        {
            removeTail();
            Point newHead = drawNewHead();
        }

        private void removeTail()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            tail.Clear();
            tail.Draw();
        }

        private Point drawNewHead()
        {
            Point head = pList.Last();
            Point newHead = new Point(head);
            newHead.Move(1, this.direction);
            pList.Add(newHead);
            newHead.Draw();

            return newHead;
        }

        public void handleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.Left;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.Right;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.Up;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.Down;
            }
        }
    }
}
