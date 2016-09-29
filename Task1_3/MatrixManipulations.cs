using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Task1_3_library;
using System;
using System.Configuration;

namespace Task1_3
{
    class MatrixManipulations
    {
        public int row_1;
        public int row_2;

        public int column_1;
        public int column_2;

        public string str = "";

        public double num = 0;
        public double num_1 = 0;


        public void ReadMatrixFromFile()
        {           
            String config = ConfigurationManager.AppSettings["file"];
            StreamReader fs = new System.IO.StreamReader(config);
            str = fs.ReadLine();
            Int32.TryParse(str, out row_1);
            str = fs.ReadLine();
            Int32.TryParse(str, out column_1);
            str = fs.ReadToEnd();
            fs.Close();
            string[] row = str.Split('\n');

            double[,] MatrixA = this.WriteMatrix(row, row_1, column_1);

            Int32.TryParse(row[row_1], out row_2);
            Int32.TryParse(row[(row_1) + 1], out column_2);

            string[] new_row = row.Skip(row_1 + 2).ToArray();

            double[,] MatrixB = this.WriteMatrix(new_row, row_2, column_2);

            Class1 cl = new Class1();

            double[,] result = cl.MultiplyMatrix(MatrixA, MatrixB, row_1, column_1, row_2, column_2);
            this.PrintMatrix(result);
        }



        public void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < matrix.GetLength(1); ++j)
                    Console.Write("{0} ", matrix[i, j].ToString("F", CultureInfo.InvariantCulture));
            Console.WriteLine("");


        }

        public double[,] WriteMatrix(string[] str, int rows, int columns)
        {
            string[] column = str[0].Split(' ');
            double[,] Matrix = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                column = str[i].Split(' ');

                for (int j = 0; j < columns; j++)
                {
                    num_1 = Convert.ToDouble(column[j]);
                    Matrix[i, j] = num_1;
                }
            }
            return Matrix;
        }
    }
}