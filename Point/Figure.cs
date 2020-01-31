using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;



namespace Point
{
    class Figure
    {
        protected List<MyPoint> pointList = new List<MyPoint>();
        

        

        public void DrawFigure()
        {
            foreach (MyPoint point in pointList)
            {
                point.Draw();
            }
        }

        public bool IsHitByPoint(MyPoint _point)
        {
            foreach (MyPoint _p in pointList)
            {
                if (_p.IsHit(_point))
                {
                    return true;
                }

            }

            return false;
        }

        public bool IsHitByFigure(Figure figure)
        {
            foreach (MyPoint point in pointList)
            {
                if (figure.IsHitByPoint(point))
                {
                    return true;
                }
            }

            return false;
        }

        
    }
}
