using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.Refactoring.Math
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFactory factory1 = new FactorialFactory();
            MathFactory factory2 = new FibonacciFactory();

            MathContainer factorial = factory1.CreateInstance();
            MathContainer fibonacci = factory2.CreateInstance();

            Console.WriteLine("Count Factorial form 1 to 8:");
            for (int i = 1; i <= 8; i++)
            {
                factorial.Add();
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(factorial[i].ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Count Fibonacci form 1 to 8:");

            for (int i = 1; i <= 8; i++)
            {
                fibonacci.Add();
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(fibonacci[i].ToString());
            }
            Console.ReadLine();

        }
    }
}
