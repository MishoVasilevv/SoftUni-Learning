using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;

        private double width;

        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public bool exceptionFlag { get; set; }

        public double Length
        {
            get => this.length;

            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                    exceptionFlag = true;
                }

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;

            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Width cannot be zero or negative.");
                    exceptionFlag = true;
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;

            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Height cannot be zero or negative.");
                    exceptionFlag = true;
                }

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            double surfaceArea = 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;

            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh

            double lateralSurfaceArea = 2 * Length * Height + 2 * Width * Height;

            return lateralSurfaceArea;
        }

        public double Volume()
        {
            //Volume = lwh

            double volume = Length * Width * Height;

            return volume;
        }
    }
}
