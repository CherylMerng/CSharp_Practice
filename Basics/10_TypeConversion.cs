using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _10_TypeConversion
    {
        public static void _TypeConversion() {

            // Type Conversion/ Casting

            // Implicit

            int val1 = 10;
            double val2 = val1;
            Console.WriteLine(val1);
            Console.WriteLine(val2);


            // Explicit

            int weight = (int)68.2;     // 68
            int height = (int)175.7;   // 175
            Console.WriteLine(weight);
            Console.WriteLine(height);

            double A = 10.0;
            int B = (int)A;
            Console.WriteLine(B);   // 10

            // Other

            // string? userInput = Console.ReadLine()!;
            // int int_UserInput = Convert.ToInt32(userInput);
            // decimal decimal_UserInput = Convert.ToDecimal(userInput);
            // float float_UserInput = Convert.ToSingle(userInput);
            // double doulbe_UserInput = Convert.ToDouble(userInput);

            //  deciaml - ToDecimal()
            //  float - ToSingle()
            //  double - ToDouble() methods
        }
    }
}
