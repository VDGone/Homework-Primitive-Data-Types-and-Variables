using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Insert number:");
            string fNumber = Console.ReadLine();
            a = double.Parse(fNumber);

            double b;
            Console.WriteLine("Insert another number:");
            string sNumber = Console.ReadLine();
            b = double.Parse(sNumber);

            double eps = 0.000001;
            double difference = Math.Abs (a - b);

            bool isTrue = difference < eps;
            Console.WriteLine("Numbers are equals or almost equals is {0}.", isTrue);



        }
    }
}
