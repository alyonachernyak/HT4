using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part2;
using System.Globalization;

namespace Part2_Runner
{
    class TypeOfEquation
    {
        public void SolveTheEquation()
        {
            List<double> index = new List<double>();
            Equation equation = new Equation();
            Logs logs = new Logs();

            Console.WriteLine("Choose the type of equation. If you prefere quadratic equation input 1, if you prefere linear equation input 2: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter coefficient: ");            

            switch (str)
            {
                case "1":
                    double a = this.ReadCoef("a");
                    double b = this.ReadCoef("b");
                    double c = this.ReadCoef("c");
                    index.Add(a);
                    index.Add(b);
                    index.Add(c);
                    logs.AddToList("Quadratic Equation");
                    double root_1 = equation.SolveQuadraticEquation(index, true);
                    Console.WriteLine($"Root 1: {root_1.ToString("F", CultureInfo.InvariantCulture)}");
                    logs.AddToList(root_1.ToString());
                    double root_2 = equation.SolveQuadraticEquation(index, false);
                    Console.WriteLine($"Root 2: {root_2.ToString("F", CultureInfo.InvariantCulture)}");
                    logs.AddToList(root_2.ToString());
                    logs.PrintLog();
                    break;

                case "2":
                    double m = this.ReadCoef("a");
                    double n = this.ReadCoef("b");
                    index.Add(m);
                    index.Add(n);
                    logs.AddToList(DateTime.Now + " " + "Linear Equation");
                    double res = equation.SolveLinearEquation(index);
                    Console.WriteLine($"Root: {res.ToString("F", CultureInfo.InvariantCulture)}");
                    logs.AddToList(res.ToString());
                    logs.PrintLog();
                    break;

                default:
                    string message = "Error! There are only two options: 1 or 2!";
                    Console.WriteLine(message);
                    logs.AddToList(message);
                    logs.PrintLog();
                    break;
            }
        }
            

         public double ReadCoef(string coef)
        {
            double num = 0.0;
            do
            {
                Console.WriteLine("Input " + coef + " : ");
                string str = Console.ReadLine();
                if (Double.TryParse(str, out num))
                {
                    break;
                }
                else
                {
                    string message = "There is no number! Try to enter again!";
                    Console.WriteLine(message);
                    Logs logs = new Logs();
                    logs.AddToList(message);
                    continue;
                }
            } while (true);
            return num;          
        }
    }
}
