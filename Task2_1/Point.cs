using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Point
    {
        public  double X { get; set; }
        public  double Y { get; set; }

        public Point(double x, double y)  
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Point p = obj as Point;

            if ((System.Object)p == null)
            {
                return false;
            }

            return (X == p.X) && (Y == p.Y);
        }

        public override string ToString()
        {
            return base.ToString() + ": " + X + " " + Y;
        }
    }
}
