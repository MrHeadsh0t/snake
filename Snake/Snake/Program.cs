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
            //TODO Optimize!


            #region Borders
            // Boreders
            Console.SetBufferSize(120, 30);
            HorizontalLine border1 = new HorizontalLine(0, 119, 0, '+');
            VerticalLine border2 = new VerticalLine(0, 29, 119, '+');
            HorizontalLine border3 = new HorizontalLine(0, 119, 29, '+');
            VerticalLine border4 = new VerticalLine(0, 29, 0, '+');
            #endregion

            Point start = new Point(4,5,'*');
            Snake snake = new Snake(start,4,direction.RIGTH);
            snake.Draw();

            Console.ReadLine();

        }
    }
}
