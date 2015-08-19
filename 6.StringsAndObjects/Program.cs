using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPartOne = "Hello";
            string textPartTwo = "World";
            object concatenation = textPartOne + " " + textPartTwo;
            string textOneAndTwo = (string)concatenation;

            Console.WriteLine(textOneAndTwo);

        }
    }
}
