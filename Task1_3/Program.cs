using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_3_library;
namespace Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixManipulations manipulation = new MatrixManipulations();
            manipulation.ReadMatrixFromFile();
        }
    }
}
