using System;

namespace Abstraction
{
    public abstract class Figure
    {
        /// <summary>
        /// There was a typo in two of the fields. 
        /// Added abstract method to calculate perimeter, since it's applicable for all figures.
        /// All shapes interpret methods in thir own way, changed the  files names as wells o they meet the naming 
        /// convention fileName == class name
        /// Removed the fields and constructors to derived classes none of em has place here. 
        /// </summary>
        public abstract double CalculateSurface();
        public abstract double CalculatePerimeter();
    }
}
