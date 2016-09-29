using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task1_3_library
{
    public class Class1
    {
        public double[,] MultiplyMatrix(double[,] a, double[,] b, int a_row, int a_column, int b_row, int b_column)
        {
            if (a_column == b_row)
            {
                double[,] MatrixC = new double[a_row, b_column];
                for (int i = 0; i < a_row; i++)
                {
                    for (int j = 0; j < b_column; j++)
                    {
                        MatrixC[i, j] = 0;
                        for (int k = 0; k < a_column; k++) // OR k<b_row
                            MatrixC[i, j] = MatrixC[i, j] + a[i, k] * b[k, j];
                    }
                }
                return MatrixC;
            }
            else
            {
                Console.WriteLine("\n Number of columns in First Matrix should be equal to Number of rows in Second Matrix.");
                Console.WriteLine("\n Please re-enter correct dimensions.");
                Environment.Exit(-1);
                double[,] m = new double[0, 0];
                return m;
            }
        }
    }
}

