using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class CalculateBirthYearProgram
    {
        public static void CalculateBirthYear() {

            string? userName = "";
            int? userAge = 0;
            int? currentYear = 0;

            Console.WriteLine("Please enter your name: ");
            userName = Console.ReadLine()!;
            Console.WriteLine("Please enter your age: ");
            userAge = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Please enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine("Hello World! My name is {0} and I am {1} years old. " +
                "I was born in {2}.", userName, userAge, currentYear - userAge);

        }
    }
}
