using System;

public class Shape
{
    public Shape(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Width { get; set; }

    public double Height { get; set; }

    public static Shape RotateShape(Shape inputShape, double rotationAngle)
    {
        double rotationAngleCos = Math.Abs(Math.Cos(rotationAngle));
        double rotationAngleSin = Math.Abs(Math.Sin(rotationAngle));
        double newShapeWidth = (rotationAngleCos * inputShape.Width) + (rotationAngleSin * inputShape.Height);
        double newShapeHeight = (rotationAngleSin * inputShape.Width) + (rotationAngleCos * inputShape.Height);
        Shape outputShape = new Shape(newShapeWidth, newShapeHeight);

        return outputShape;
    }
}