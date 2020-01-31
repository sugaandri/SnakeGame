using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Point
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            //Console.SetWindowSize(80, 25);
            //Console.SetBufferSize(80, 25);


            /*HorizontalLine topLine = new HorizontalLine(0, 78, 0, '*');
			topLine.DrawFigure();
			HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '*');
			bottomLine.DrawFigure();
			VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
			leftLine.DrawFigure();
			VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
			rightLine.DrawFigure();

			HorizontalLine hrLine = new HorizontalLine(5, 10, 10, '*');
            hrLine.DrawFigure();
            VerticalLine vrLine = new VerticalLine(11, 20, 5, '*');
            vrLine.DrawFigure();*/

            Console.BackgroundColor=ConsoleColor.White;
            Walls walls = new Walls(80, 25);
            walls.DrawWalls();
            Bridge bridges = new Bridge();
            bridges.DrawBridges();
            
            
            MyPoint tail = new MyPoint(6, 5, '*');
            Snake snake = new Snake(tail, 4, Direction.RIGHT);
            snake.DrawFigure();
            Console.BackgroundColor = ConsoleColor.White;
            /*snake.MoveSnake();
            Thread.Sleep(100);
            snake.MoveSnake();
            Thread.Sleep(100);
            snake.MoveSnake();
            Thread.Sleep(100);
            snake.MoveSnake();*/

            FoodCatering foodCatered = new FoodCatering(78, 24, '€');
            MyPoint food = foodCatered.CaterFood();
            food.Draw();
            
            while (true)
            {
                
                Thread.Sleep(100);

                if (walls.IsHitByFigure(snake))
                {
                    break;
                }
                if (walls.HitsTheObstacle(snake))
                {
                    break;
                }
                
                if (snake.Eat(food))
                {
                    food = foodCatered.CaterFood();
                    food.Draw();
                }
                else
                {
                    snake.MoveSnake();
                }
                
                

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ReadUserKey(key.Key);
                    /*if (key.Key == ConsoleKey.LeftArrow)
                    {
                        snake.Direction = Direction.LEFT;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        snake.Direction = Direction.RIGHT;
                    }
                    else if (key.Key == ConsoleKey.UpArrow)
                    {
                        snake.Direction = Direction.UP;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        snake.Direction = Direction.DOWN;
                    }*/
                }
            }

            Console.Clear();
            WriteGameOver();

            Console.ReadLine();
		}

        public static void WriteGameOver()
        {
            Console.Beep();
            int xOffset = 33;
            int yOffset = 10;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            ShowMessage("============", xOffset, yOffset++);
            ShowMessage("GAME OVER!!!",xOffset, yOffset++);
            ShowMessage("============", xOffset, yOffset++);

        }

        public static void ShowMessage(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

        /*public int ChooseLevel()
        {
            Console.WriteLine("Choose a level. Press 1, 2 or 3");
            int speed = 7;
            
            return speed;
        }*/
    }
}
