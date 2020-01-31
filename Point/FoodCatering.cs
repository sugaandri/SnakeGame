using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace Point
{
    class FoodCatering
    {
        int MapWidth;
        int MapHeight;
        char Symbol;

        Random rnd = new Random();

        public FoodCatering(int _mapWidth, int _mapHeight, char _symbol)
        {
            MapHeight = _mapHeight;
            MapWidth = _mapWidth;
            Symbol = _symbol;
        }

        public MyPoint CaterFood()
        {
            int x = rnd.Next(2, MapWidth - 2);
            int y = rnd.Next(2, MapHeight - 2);
            return new MyPoint(x, y, Symbol);
        }

        /*public void CreateFood()
        {
            FoodCatering foodCatered = new FoodCatering(78, 24, '€');
            MyPoint food = foodCatered.CaterFood();
            food.Draw();
        }*/
    }
}
