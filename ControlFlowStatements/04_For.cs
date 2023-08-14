using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowStatements
{ 
    internal class _04_For
    {
        public static void _For()
        {
            int[] myNumbers = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < myNumbers.Length; i++) {
                Console.WriteLine(myNumbers[i]);    
            }
        }
    }
}
