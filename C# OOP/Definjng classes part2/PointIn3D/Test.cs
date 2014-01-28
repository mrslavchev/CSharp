using System;
using System.Collections.Generic;


class Test
{
    static void Main(string[] args)
    {
        Point3D point = new Point3D(3,4,5);
        Point3D secondPoint = new Point3D(1, 2, 3);
        Console.WriteLine(point);
        Console.WriteLine();
        Console.WriteLine(Point3D.center);

        Path firstPath = new Path();
        firstPath.AddPoint(secondPoint);
        firstPath.AddPoint(point);
        firstPath.AddPoint(secondPoint);

        PathStorage.SavePath(firstPath);
        List<Path> pathList = PathStorage.LoadPath();
        foreach (var path in pathList)
        {
            Console.WriteLine("Path Start: ");
            foreach (var pointers in path.Paths)
            {
                Console.WriteLine(pointers);
            }
            Console.WriteLine("Path End:");
        }
    }
}

