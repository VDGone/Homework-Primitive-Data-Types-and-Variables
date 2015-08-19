using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (int value = 0; value < 255; value++)
            {
                Console.WriteLine((char)value);
            }
        }
    }
}
