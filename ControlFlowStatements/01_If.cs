using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowStatements
{
    internal class _01_If
    {
        public static void _If() {

            int userAge;

            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid Age");
                Console.WriteLine("Age must be between 0 and 100");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Sorry you are underage");
            }
            else if (userAge < 21)
            {
                Console.WriteLine("You need parental consent");
            }
            else {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You may sign up for the event!");

            }
        }
    }
}
