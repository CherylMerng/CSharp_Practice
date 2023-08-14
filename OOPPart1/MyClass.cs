using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1
{
    // 2 - Static

    internal class MyClass
    {
        //Non static members
        public string message = "Hello World";
        public string Name { get; set; }
        public void DisplayName() {
            Console.WriteLine("Name = {0}", Name);
        }

        // static members
        public static string greetings = "Good morning";
        public static int Age { get; set; }
        public static void DisplayAge()
        {
            Console.WriteLine("Age = {0}", Age);
        }

    }
}
