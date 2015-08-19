using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Number value first time: a = {0} and b = {1}", a, b);

            a = b + a;
            b = a - b;
            a = a - b;

            Console.WriteLine("Number value second time: a = {0} and b = {1}", a, b);
           


        }
    }
}
