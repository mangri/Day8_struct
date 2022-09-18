using System;
using System.ComponentModel.DataAnnotations;

namespace structSimpleRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(1.2, 3.4);
            Rectangle rect2 = new Rectangle(5.6, 7.8);
            Rectangle rect3 = new Rectangle(9.1, 1.9);
            Console.WriteLine("Three rectangles with area of " +
                "{0:0.00}, {1:0.00} and {2:0.00} square units",
                rect1.rectArea(), rect2.rectArea(), rect3.rectArea());
        }
        struct Rectangle
        {
            public double Length;
            public double Width;
            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
            }
            public double rectArea()
            {
                return Length * Width;
            }
        } 
    }
}
