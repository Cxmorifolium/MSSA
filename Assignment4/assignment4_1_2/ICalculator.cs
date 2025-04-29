using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_2
{
    internal interface ICalculator
    {
        double Calculate(double x, double y, string op);
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
        double Percent(double x, double y);
        double Negate(double x);
    }

}
