using System;
using Mathematics;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(1, 2));
            Console.WriteLine(Calculator.Subtract(1, 2));
            Console.WriteLine(Calculator.Divide(4, 2));
            Console.WriteLine(Calculator.Multiply(3, 2));
        }
    }
}
