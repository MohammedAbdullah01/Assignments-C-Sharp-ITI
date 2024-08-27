﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay3CSharp
{
    internal class Point3D
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0) { }
        public Point3D(int _x) : this(_x, 0, 0) {}
        public Point3D(int _x, int _y) : this(_x, _y, 0) { }
        public Point3D(int _x , int _y , int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }


        public override bool Equals(object? obj)
        {
            if(obj is Point3D other)
            {
                return X == other.X && Y == other.Y && Z == other.Z;
            }
            return false ;
        }

        public override int GetHashCode()
        {
            return X * Y * Z * 2024 / 12 * 30;
        }


        public static bool operator == (Point3D point1 , Point3D point2)
        {
            if (ReferenceEquals(point1, point2))
            {
                return true;
            }

            if (ReferenceEquals(point1, null) || ReferenceEquals(point2 , null))
            {
                return false;
            }

            return point1.Equals(point2);
        }

        public static bool operator !=(Point3D point1, Point3D point2)
        {
            return !(point1 == point2);
        }


        public static void Display(Point3D[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Point {i + 1 }: {arr[i].ToString()}"); 
            }
        }

        public override string ToString()
        {
            return $"\n\tX: {X}\n\tY: {Y}\n\tZ: {Z}";
        }
    }
}
