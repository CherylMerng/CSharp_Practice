using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowStatements
{
    internal class Test
    {
        public static void _Test() {

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
        }
    }
}
