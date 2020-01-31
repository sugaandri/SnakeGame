using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Point
{
    class Walls
    {
        List<Figure> wallList, obstacleList, realObstacleList;

        public Walls(int _mapWidth, int _mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine topLine = new HorizontalLine(0, _mapWidth - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, _mapWidth - 2, _mapHeight - 2, '+');
            VerticalLine leftLine = new VerticalLine(0, _mapHeight - 2, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, _mapHeight - 2, _mapWidth - 2, '+');
            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

            obstacleList = new List<Figure>();
            HorizontalLine levelOneObstacle1 = new HorizontalLine(63, 73, 20, '+');
            HorizontalLine levelOneObstacle2 = new HorizontalLine(20, 30, 10, '+');
            VerticalLine levelOneObstacle3 = new VerticalLine(10, 20, 40, '+');
            VerticalLine levelOneObstacle4 = new VerticalLine(5, 15, 60, '+');
            obstacleList.Add(levelOneObstacle1);
            obstacleList.Add(levelOneObstacle2);
            obstacleList.Add(levelOneObstacle3);
            obstacleList.Add(levelOneObstacle4);
            GenerateObstacles();
        }

        public void GenerateObstacles()
        {
            Console.WriteLine("Select the number of obstacles. Press 1, 2, 3 or 4");
            int userChoice = int.Parse(Console.ReadLine());
            DrawObstacles(userChoice);
        }


        public void DrawObstacles(int userChoice)
        {
            for (int i = 0; i <= userChoice - 1; i++)
            {
                Figure obstacle = obstacleList[i];
                realObstacleList = new List<Figure>();
                realObstacleList.Add(obstacle);
                obstacle.DrawFigure();
            }
        }

        public void DrawWalls()
        {
            foreach(Figure wall in wallList)
            {
                wall.DrawFigure();
            }
        }

        public bool IsHitByFigure(Figure _figure)
        {
            foreach (Figure wall in wallList)
            {
                if (wall.IsHitByFigure(_figure))
                {
                    return true;
                }
            }

            return false;
        }

        public bool HitsTheObstacle(Figure _obstacle)
        {
            foreach (Figure obstacel in realObstacleList)
            {
                if (obstacel.IsHitByFigure(_obstacle))
                {
                    return true;
                }
            }

            return false;
        }

        

    }
}
