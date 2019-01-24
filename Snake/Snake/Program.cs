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

            Wall wall = new Wall(120, 15);

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
                if (wall.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else if (Console.KeyAvailable)
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
