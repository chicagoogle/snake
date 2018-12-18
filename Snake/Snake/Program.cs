using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //Console.WriteLine(Console.LargestWindowHeight);
            //Console.WriteLine(Console.LargestWindowWidth);
            //Console.SetWindowPosition(50, 0);
            //Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);


            HorisontalLine top = new HorisontalLine(0, 78, 0, '.');
            top.Drow();

            HorisontalLine bottom = new HorisontalLine(0, 78, 23, '.');
            bottom.Drow();

            VerticalLine left = new VerticalLine(0, 23, 0, '.');
            VerticalLine right = new VerticalLine(0, 23, 78, '.');


            left.Drow();
            right.Drow();
        }
    }
}
