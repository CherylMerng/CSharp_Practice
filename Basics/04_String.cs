using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _04_String
    {
        public static void _String() {

        // 4.1 String

            string message = "";
            string myName = "Hello World, " + "my name is Jamie";
            

        // 4.2 String Property - .length
            Console.WriteLine(myName.Length);

        // 4.3 String Methods - Substring(), Equals(), Split()

            message = "Hello World";
            string newMessage = message.Substring(2, 5);
            Console.WriteLine(newMessage);

            string firstString = "This is Jamie";
            string secondString = "Hello";
            Console.WriteLine(firstString.Equals("This is Jamie"));   // true
            Console.WriteLine(firstString.Equals(secondString));    // false

            //  Split() method
            //  splits a string into substrings based on an array of user - defined separators.

            string[] separator = { ",", ";"};
            string names = "Peter, John; Andy,  , David";

            string[] substrings = names.Split(separator, StringSplitOptions.None);
            Console.WriteLine(substrings.Length);   // 5

            string[] substrings2 = names.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(substrings2.Length);   // 4


        }
    }
}
