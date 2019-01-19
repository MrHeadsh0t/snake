using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        // 0 -Up; 1 - Rigth; 2 - Down; 3-Left;
        public Snake(Point tail,int length,direction direction)
        {
            pList = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

    }
}
