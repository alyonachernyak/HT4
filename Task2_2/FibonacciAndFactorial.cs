using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public static class FibonacciAndFactorial
    {
        public static int Fibonacci(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }
        }

        public static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return Factorial(number - 1) * number;
            } 
        }
    }
}
