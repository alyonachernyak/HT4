using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    public class CountRectangle
    {
        public static double  rectangleSquare = 13.72;
        public double surfaceArea { get; set; }

        public CountRectangle(double temp)
        {
            this.surfaceArea = temp;
        }

        public int GetCount()
        {
            return Convert.ToInt32(this.surfaceArea / rectangleSquare);
        }
        

    }
}
