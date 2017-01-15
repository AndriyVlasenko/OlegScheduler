using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(CalculatorService));
            sh.Open();
            Console.WriteLine("up and running");
            Console.ReadLine();

            sh.Close();
            Console.WriteLine("closed");


        }
    }
}
