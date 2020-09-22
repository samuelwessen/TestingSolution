using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCoreLibrary
{
    public class Calculator
    {
        public double Add(double firstnumber, double secondnumber)
        {
            return firstnumber + secondnumber;
        }

        public double Subtract(double first, double second)
        {
            return first - second;
        }

        public double Multiply(double first, double second)
        {
            return first * second;
        }
    }
}
