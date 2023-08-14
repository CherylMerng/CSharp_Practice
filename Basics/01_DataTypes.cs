using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _01_DataTypes
    {
        public static void _DataType()
        {
            // data types
            // byte =  integral numbers (0 to 255)
            // short
            // int = numbers with no decimal or fractional parts
            // long
            // float
            // double
            // decimal
            // char
            // bool

            // variable
            // name
            // initialize
            // assign

            // basic operators
            // + - * / %

            // assignment operators
            // =
            // ++ 
            // x++ => x = x+1
            // --

            int counter = 0;

            Console.WriteLine(counter++);   // 0
            Console.WriteLine(counter); // 1
            counter = counter + 1;
            Console.WriteLine(counter); // 2
        }
    }
}
