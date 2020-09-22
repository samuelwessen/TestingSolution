using SharedCoreLibrary;
using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(1, 3);

            Console.WriteLine(actual);
        }
    }
}
