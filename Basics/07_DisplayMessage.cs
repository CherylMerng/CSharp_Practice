using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _07_DisplayMessage
    {
        public static void _DisplayMessage() {

            Console.Write("Hello, ");
            Console.WriteLine("who are you?");

            int results = 79;
            Console.WriteLine("{0}! You scored {1} marks for your test.", 
            "Good morning", results);

            // Format specifiers - C and F

            Console.WriteLine("The number is {0:F3}.", 123.45678);  // 123.457
            Console.WriteLine("Deposit = {0:C}. Amount balance = {1:C}.",
            2125, 12345.678);
            // Deposit = $2,125.00. Amount balance = $12,345.68.

        }
    }
}
