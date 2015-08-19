using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DeclareVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort firstNumber = 52130;
            sbyte secondNumber = -115;
            int thirdNumber = 4825932;
            byte fourthNumber = 97; // or sbyte
            short fifthNumber = -10000;

            Console.WriteLine("{0},{1},{2},{3},{4}", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
    }
}
