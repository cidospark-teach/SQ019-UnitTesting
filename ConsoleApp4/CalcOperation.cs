using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // TDD => Test Driven Development
    public class CalcOperation
    {
        public double Divide(double x, double y)
        {
            if (y <= 0)
                throw new ArithmeticException("Error: Cannot divide by zero!");

            return x / y;
        }

        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public string GetFullName(string fn, string sn)
        {
            return $"{fn} {sn}";
        }
    }
}
