using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        List<Figure> walllist;

        public Wall(int maxHigth, int maxWidth)
        {
            walllist = new List<Figure>();

            #region Borders
            // Boreders
            Console.SetBufferSize(maxWidth, maxHigth);
            HorizontalLine border1 = new HorizontalLine(0, (maxWidth - 1), 0, '+');
            VerticalLine border2 = new VerticalLine(0, (maxHigth - 1), maxWidth - 1, '+');
            HorizontalLine border3 = new HorizontalLine(0, maxWidth - 1, maxHigth - 1, '+');
            VerticalLine border4 = new VerticalLine(0, maxHigth - 1, 0, '+');

            walllist.Add(border1);
            walllist.Add(border2);
            walllist.Add(border3);
            walllist.Add(border4);
            #endregion
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in walllist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }

            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in walllist)
            {
                wall.Draw();
            }
        }
    }
}

