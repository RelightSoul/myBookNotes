using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.OverloadedOps
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public override string ToString()
        {
            return $"[{X}.{Y}]";
        }

        public static Point operator +(Point p1, Point p2)
        { return new Point(p1.X + p2.X, p1.Y + p2.Y); }

        public static Point operator -(Point p1, Point p2)
        { return new Point(p1.X - p2.X, p1.Y - p2.Y); }

        public static Point operator +(Point p1, int charge)
        { return new Point(p1.X + charge, p1.Y + charge); }

        public static Point operator ++(Point p1)
        { return new Point(p1.X + 1, p1.Y + 1); }

        public override bool Equals(object o)
        {
            return o.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public int CompareTo(Point other)
        {
            if (this.X>other.X && this.Y>other.Y)
            {
                return 1;
            }
            if (this.X < other.X && this.Y < other.Y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static bool operator == (Point p1, Point p2)
        {
            return p1.Equals(p2);               
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }
        public static bool operator > (Point p1,Point p2)
        {
            return p1.CompareTo(p2) > 0;
        }
        public static bool operator <(Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return p1.CompareTo(p2) >= 0;
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return p1.CompareTo(p2) <= 0;
        }
    }
}
