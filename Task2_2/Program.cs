using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = FibonacciAndFactorial.Factorial(number);
            int fibonacci = FibonacciAndFactorial.Fibonacci(number);
            Console.WriteLine($"Factorial {factorial} \nFibonacci {fibonacci}", factorial, fibonacci);
        }
    }
}
