using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Equation
    {
        public double SolveQuadraticEquation(List<double> index, bool pos)
        {
            double a = index[0];
            double b = index[1];
            double c = index[2];
            var preRoot = (b * b) - (4 * a * c);
            if (preRoot < 0)
            {
                return double.NaN;
            }
            else
            {
                var sgn = pos ? 1.0 : -1.0;
                return (sgn * Math.Sqrt(preRoot) - b) / (2.0 * a);
            }
        }

        public double SolveLinearEquation(List<double> index)
        {
            double a = index[0];
            double b = index[1];
            if (a == 0)
            {
                return double.NaN;
            }
            else
            {
                 var root = (-b) / a;
                return root;
            }         
        }
    }
}
