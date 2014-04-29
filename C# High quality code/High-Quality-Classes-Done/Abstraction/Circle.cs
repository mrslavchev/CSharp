namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius can not be less than or equal ot zero.");
                }

                this.radius = value;
            }
        }

        public override double CalculateSurface()
        {
            double area = Math.PI * (this.Radius * this.Radius);
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (Math.PI * this.Radius);
            return perimeter;
        }
    }
}