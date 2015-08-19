using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            byte age;
            string ageOfPerson = Console.ReadLine();
            age = byte.Parse(ageOfPerson);

            Console.WriteLine("Enter your gender (m/f): ");
            char gender;
            string genderOfPerson = Console.ReadLine();
            gender = char.Parse(genderOfPerson);

            Console.WriteLine("Your personal ID number: ");
            ulong iDNumber;
            string personalIDNumber = Console.ReadLine();
            iDNumber = ulong.Parse(personalIDNumber);

            Console.WriteLine("Your unique employee number (8 numbers): ");
            ulong uEmployeeNumber;
            string uniqueEmployeeNumber = Console.ReadLine();
            uEmployeeNumber = ulong.Parse(uniqueEmployeeNumber);

        }
    }
}
