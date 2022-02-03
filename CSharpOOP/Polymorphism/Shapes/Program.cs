using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Rectangle(3, 5);
            Shape shape2 = new Circle(4);

            Console.WriteLine(shape1.Draw());
            Console.WriteLine(shape1.CalculateArea());
            Console.WriteLine(shape1.CalculatePerimeter());

            Console.WriteLine(shape2.Draw());
            Console.WriteLine(shape2.CalculateArea());
            Console.WriteLine(shape2.CalculatePerimeter());
        }
    }
}
