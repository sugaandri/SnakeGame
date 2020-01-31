using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Point
{
    class Bridge : Figure
    {
        List<Figure> bridgeList;
        protected List<MyPoint> bridgePointList = new List<MyPoint>();

        public Bridge()
        {
            bridgeList = new List<Figure>();
            VerticalLine bridgeEast = new VerticalLine(1, 4, 77, '*');
            VerticalLine bridgeWest = new VerticalLine(19, 22, 1, '*');
            bridgeList.Add(bridgeEast);
            bridgeList.Add(bridgeWest);
        }

        public void DrawBridges()
        {
            foreach (Figure bridge in bridgeList)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                bridge.DrawFigure();
            }
        }

        public void DrawFigureBridge()
        {
            foreach (MyPoint point in bridgePointList)
            {
                point.Draw();
            }
        }

        public bool HitsTheBridge(Figure _figure)
        {
            foreach (Figure bridge in bridgeList)
            {
                if (bridge.IsHitByFigure(_figure))
                {
                    return true;
                }
            }

            return false;
        }

        /*public void CrossTheBridge()
        {
            MyPoint head = new MyPoint();
        }*/

        public void ConnectedBridges(MyPoint head, MyPoint bridgeList)
        {
            if(head == bridgeList)
            {
                foreach(MyPoint point in pointList)
                {
                    
                }
            }
        }
    }

}
