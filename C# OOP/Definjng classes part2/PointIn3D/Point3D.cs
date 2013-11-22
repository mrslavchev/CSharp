using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public struct Point3D
    {
        public int coordX { get; set; }
        public int coordY { get; set; }
        public int coordZ { get; set; }

        public static readonly Point3D center = new Point3D(0, 0, 0);

        public Point3D(int coordX, int coordY, int coordZ) : this()
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.coordZ = coordZ;
        }

        public override string ToString()
        {
            return string.Format("X= {0}\nY= {1}\nZ= {2}", this.coordX, this.coordY, this.coordZ);
        }
    }

