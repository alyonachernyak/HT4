using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(3.76, 984.23);
            Point pointB = new Point(5.55555, 984.23);
            Console.WriteLine(pointA);
            Console.WriteLine(pointA.Equals(pointB));
        }
    }
}
