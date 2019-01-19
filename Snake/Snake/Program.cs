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
            //TODO Optimize!


            #region Borders
            // Boreders
            Console.SetBufferSize(120, 30);
            HorizontalLine border1 = new HorizontalLine(0, 119, 0, '+');
            VerticalLine border2 = new VerticalLine(0, 29, 119, '+');
            HorizontalLine border3 = new HorizontalLine(0, 119, 29, '+');
            VerticalLine border4 = new VerticalLine(0, 29, 0, '+');
            #endregion

            #region Points
            //Змейка
            Point start = new Point(4,5,'*'); // Хвост
            Snake snake = new Snake(start,4,direction.RIGTH); // Создаём змейку
            snake.Draw(); // Рисуем её
            snake.Move();

            //Еда
            FoodCreator foodCreator = new FoodCreator(120, 30, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            #endregion




            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.dirChange(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
