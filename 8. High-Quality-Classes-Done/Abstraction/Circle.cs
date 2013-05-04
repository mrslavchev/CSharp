using System;

namespace Abstraction
{
     public class Circle : Figure
    {
        protected int radius;
        protected int Radius { get; private set; }
        public Circle(int radius)
        {
            this.Radius = radius;
        }
        public override double CalculateSurface()
        {
            double area = Math.PI * (this.Radius * this.Radius);
            return area;
        }
        public override double CalculatePerimeter()
        {
            double perimeter = 2*(Math.PI * this.Radius);
            return perimeter;
        }
    }
}
