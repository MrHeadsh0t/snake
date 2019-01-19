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

            Console.SetBufferSize(120, 30);
            HorizontalLine border1 = new HorizontalLine(0, 119, 0, '+');
            VerticalLine border2 = new VerticalLine(0, 29, 119, '+');
            HorizontalLine border3 = new HorizontalLine(0, 119, 29, '+');
            VerticalLine border4 = new VerticalLine(0, 29, 0, '+');
                       
            Console.ReadLine();

        }
    }
}
