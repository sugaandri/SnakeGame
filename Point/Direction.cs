using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace Point
{
    enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }

    class Snake : Figure
    {
        public Direction Direction;

        public Snake(MyPoint tail, int length, Direction _direction)
        {
            Direction = _direction;
            for (int i = 0; i < length; i++)
            {
                MyPoint newPoint = new MyPoint(tail);
                newPoint.MovePoint(i, Direction);
                pointList.Add(tail);
                
            }
        }

        public void MoveSnake()
        {
            MyPoint tail = pointList.First();
            pointList.Remove(tail);
            MyPoint head = GetNextPoint();
            pointList.Add(head);
            tail.Clear();
            head.Draw();
        }

        public MyPoint GetNextPoint()
        {
            MyPoint head = pointList.Last();
            MyPoint nextPoint = new MyPoint(head);
            nextPoint.MovePoint(1, Direction);
            return nextPoint;
        }

       

        public void ReadUserKey(ConsoleKey key)
        {
            
                if (key == ConsoleKey.LeftArrow)
                {
                    Direction = Direction.LEFT;
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    Direction = Direction.RIGHT;
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    Direction = Direction.UP;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    Direction = Direction.DOWN;
                } 
        }

        public bool Eat(MyPoint _food)
        {
            MyPoint head = GetNextPoint();
            if (head.IsHit(_food))
            {
                _food.symbol = head.symbol;
                pointList.Add(_food);
                return true;
            }
            else { return false; }

        }


        /*public MyPoint GetNextPoint()
        {
            MyPoint head = pointList.Last();
            MyPoint nextPoint = new MyPoint(head);
            nextPoint.MovePoint(1, Direction);
            return nextPoint;
        }*/

    }
}
