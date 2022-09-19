using System;

namespace structRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectFixed;
            rectFixed.TopLeft = new Point(1, 10);
            rectFixed.BottomRight = new Point(10, 1);

            Random rnd = new Random();
            Point randomPoint = new Point(rnd.Next(1, 15), rnd.Next(1, 15));
            Console.Write("Random point {0},{1} ", randomPoint.X, randomPoint.Y);

            if(CheckPoint(rectFixed, randomPoint))
            {
                Console.WriteLine("is inside rectangle {0},{1}  {2},{3} ", 
                    rectFixed.TopLeft.X, rectFixed.TopLeft.Y, 
                    rectFixed.BottomRight.X, rectFixed.BottomRight.Y);
            }
            else
            {
                Console.WriteLine("is outside rectangle {0},{1}  {2},{3} ", 
                    rectFixed.TopLeft.X, rectFixed.TopLeft.Y, 
                    rectFixed.BottomRight.X, rectFixed.BottomRight.Y);
            }

        }
        struct Point
        {
            public int X;
            public int Y;
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

        }
        struct Rectangle
        {
            public Point TopLeft;
            public Point BottomRight;
        }
        static bool CheckPoint(Rectangle rectFixed, Point randomPoint)
        {
            bool checkX = randomPoint.X >= rectFixed.TopLeft.X && 
                randomPoint.X <= rectFixed.BottomRight.X;

            bool checkY = randomPoint.Y <= rectFixed.TopLeft.Y &&
                randomPoint.Y >= rectFixed.BottomRight.Y;

            return checkX && checkY;

        }
    }
}
