using System.Collections.Generic;

/// <summary>
/// Stores sequence of points.
/// </summary>
class Path
{
    public readonly List<Point3D> paths = new List<Point3D>();

    public List<Point3D> Paths
    {
        get { return this.paths; }
    }

    public void AddPoint(Point3D point)
    {
        paths.Add(point);
    }

    public void RemovePoint(Point3D point)
    {
        paths.Remove(point);
    }

    public void ClearPath()
    {
        paths.Clear();
    }
}

