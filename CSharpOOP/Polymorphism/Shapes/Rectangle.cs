using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle
        : Shape
    {
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        private double height;
        private double width;

        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter()
        {
            return (2 * height) + (2 * width);
        }

        public override string Draw()
        {
            return "rectangle";
        }
    }
}
