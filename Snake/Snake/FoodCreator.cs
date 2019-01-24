using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeigth;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeigth, char sym)
        {
            this.mapHeigth = mapHeigth;
            this.mapWidth = mapWidth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(5, mapWidth - 5);
            int y = random.Next(5, mapHeigth - 5);
            return new Point(x, y, sym);
        }
    }
}