using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _09_AcceptUserInput
    {
        public static void _AcceptUserInput() { 
        
            string? userInput = Console.ReadLine()!;
            Console.WriteLine(userInput);

            int userInput2 = Console.Read();
            Console.Write(userInput2);
        }

    }
}
