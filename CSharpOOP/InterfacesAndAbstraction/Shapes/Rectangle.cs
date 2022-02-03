using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle
        : IDrawable
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public void Draw()
        {
            for (int i = 0; i < this.Height; i++)
            {
                for (int j = 0; j < this.Width; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
