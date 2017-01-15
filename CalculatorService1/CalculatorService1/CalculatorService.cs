using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.

    public class CalculatorService : ICalculatorService
    {
        public double AddDouble(double a, double b)
        {
            Console.WriteLine(string.Format("adding a+b, {0},{1}",a,b));
            return a + b;
        }
    }
}
