using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        static void doWork()
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);


            HorisontalLine top = new HorisontalLine(0, 78, 0, '.');
            HorisontalLine bottom = new HorisontalLine(0, 78, 23, '.');
            VerticalLine left = new VerticalLine(0, 23, 0, '.');
            VerticalLine right = new VerticalLine(0, 23, 78, '.');
            top.Drow();
            bottom.Drow();
            left.Drow();
            right.Drow();

            Point snakeTail = new Point(10, 4, '*');

            Snake snake = new Snake(snakeTail, 10, Direction.Right);
            snake.Drow();


            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    snake.handleKey(pressedKey.Key);
                }
                snake.Move();
                Thread.Sleep(100);
            }

        }
    }
}
