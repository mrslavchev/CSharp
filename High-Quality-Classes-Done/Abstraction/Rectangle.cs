using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        public int Width { get; private set; }
        public int Heigth { get; private set; }
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Heigth = height;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Heigth);
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Heigth;
            return surface;
        }
    }
}
