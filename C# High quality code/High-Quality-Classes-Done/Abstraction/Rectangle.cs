namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Heigth = height;
        }

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width can not be negative or zero.");
                }

                this.width = value;
            }
        }

        public int Heigth
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height can not be negative or zero.");
                }

                this.height = value;
            }
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