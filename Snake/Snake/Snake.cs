﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {

        direction dir;
        // 0 -Up; 1 - Rigth; 2 - Down; 3-Left;
        public Snake(Point tail, int length, direction direction)
        {
            dir = direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, dir);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                } 
            }
            return false;
        }

        public Point GetNextPoint()
        {
            Point head1 = pList.Last();
            Point nextPoint = new Point(head1);
            nextPoint.Move(1, dir);
            return nextPoint;
        }

        public void dirChange(ConsoleKey key)
        {
            if (key == ConsoleKey.UpArrow) dir = direction.UP;
            else if (key == ConsoleKey.DownArrow) dir = direction.DOWN;
            else if (key == ConsoleKey.RightArrow) dir = direction.RIGTH;
            else if (key == ConsoleKey.LeftArrow) dir = direction.LEFT;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else return false;

           
        }
    }
}
