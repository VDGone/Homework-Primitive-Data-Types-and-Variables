using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Veselin";
            string middleName = "Dimitrov";
            string lastName = "Gogoshev";
            decimal balance = 9999999.99M;
            string bankName = "Nashenska banka";
            string IBAN = "NQMABGSF";
            ulong creditCard1 = 1234567890123456;
            ulong creditCard2 = 6543210987654321;
            ulong creditCard3 = 1987654321123456;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", firstName, middleName, lastName, balance, bankName, IBAN, creditCard1, creditCard2, creditCard3);

        }
    }
}
