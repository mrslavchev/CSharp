using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Shape
{
    public double width, height;
    public Shape(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public static Shape RotateShape(
  Shape inputShape, double rotatingAngle)
    {
        Shape output = new Shape(
          Math.Abs(Math.Cos(rotatingAngle)) * inputShape.width +
            Math.Abs(Math.Sin(rotatingAngle)) * inputShape.height,
          Math.Abs(Math.Sin(rotatingAngle)) * inputShape.width +
            Math.Abs(Math.Cos(rotatingAngle)) * inputShape.height);
        return output;
    }
}


