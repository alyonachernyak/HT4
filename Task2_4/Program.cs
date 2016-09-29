using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the surface area: ");
            string str = Console.ReadLine();
            double surfaceArea = 0.0;
            Double.TryParse(str, out surfaceArea);
            CountRectangle rect = new CountRectangle(surfaceArea);
            Console.WriteLine(rect.GetCount());
        }
    }
}
