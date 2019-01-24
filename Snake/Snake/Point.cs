using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point 
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            // Конструктор
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public bool IsHit(Point pointhead)
        {
            return pointhead.x == x && pointhead.y == y;
        }

        public void Move(int offset, direction dir)
        {
            if (dir == direction.RIGTH) x += offset;
            else if (dir == direction.LEFT) x -= offset;
            else if (dir == direction.DOWN) y += offset;
            else if (dir == direction.UP) y -= offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }

    }
}
