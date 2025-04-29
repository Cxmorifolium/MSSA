using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_2
{
    internal class Math : ICalculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return x / y;
        }

        public double Percent(double x, double y)
        {
            return (x * y) / 100;
        }

        public double Calculate(double x, double y, string op)
        {
            switch (op)
            {
                case "+":
                    return Add(x, y);
                case "-":
                    return Subtract(x, y);
                case "*":
                    return Multiply(x, y);
                case "/":
                    return Divide(x, y);
                case "%":
                    return Percent(x, y);
                default:
                    throw new InvalidOperationException("Unknown operator");
            }
        }


        public double Negate(double x)
        {
            return -x;
        }

    }
}
