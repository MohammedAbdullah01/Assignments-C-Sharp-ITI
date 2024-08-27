using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LapDay2CSharp
{
    internal class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y) : this(x ,y , 0){}
        public Point3D(int x , int y  ,int z)
        { 
            X = x;
            Y = y;
            Z = z;
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y || p1.Z != p2.Z;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(obj is Point3D point )
            {
                return this == point ;

            }
            return false;
        }

        public void Display()
        {
            Console.WriteLine($"Information The Point: \nX :\t{X}\nY :\t{Y}\nZ :\t{Z}\n");
        }

        public void ChangeCoordinates(int newX , int newY , int newZ)
        {
            X = newX; Y = newY; Z = newZ;
        }

    }
}
