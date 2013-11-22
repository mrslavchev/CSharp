using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    class PathStorage
    {
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"../../PathSave.txt"))
            {
                foreach (var point in path.Paths)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static List<Path> LoadPath()
        {
            Path loadPath = new Path();
            List<Path> pathsLoaded = new List<Path>();
            using (StreamReader reader = new StreamReader(@"../../PathLoad.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line != "-")
                    {
                        Point3D point = new Point3D();
                        string[] points = line.Split(',');
                        point.coordX = int.Parse(points[0]);
                        point.coordY = int.Parse(points[1]);
                        point.coordZ = int.Parse(points[2]);
                        loadPath.AddPoint(point);
                    }

                    else
                    {
                        pathsLoaded.Add(loadPath);
                        loadPath = new Path();
                    }

                    line = reader.ReadLine();
                }
            }

            return pathsLoaded;
        }
    }

