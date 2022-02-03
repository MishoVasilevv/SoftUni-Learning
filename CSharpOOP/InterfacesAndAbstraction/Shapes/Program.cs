using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrawable rectangle = new Rectangle(6, 10);

            rectangle.Draw();
        }
    }
}
