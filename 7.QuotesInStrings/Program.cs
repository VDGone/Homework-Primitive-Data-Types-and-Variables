using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.QuotesInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string textOne = "The \"use\" of quotations causes difficulties.";
            string textTwo = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine("{0}\n{1}",textOne,textTwo);

        }
    }
}
