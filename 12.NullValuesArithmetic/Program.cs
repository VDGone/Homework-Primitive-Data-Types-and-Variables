using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullValue1 = null;
            double? nullValue2 = null;

            Console.WriteLine("\"{0}\"\"{1}\"",nullValue1, nullValue2);

            nullValue1 = 234 + nullValue1;
            nullValue2 = 234.5553 + nullValue2;

            Console.WriteLine("\"{0}\"\"{1}\"", nullValue1, nullValue2);

           







        }
    }
}
