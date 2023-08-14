using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowStatements
{
    internal class _07_DoWhile
    {
        public static void _DoWhile() {

            int counter = 100;

            do {
                Console.WriteLine("Counter = {0}", counter);
                counter++;
            }
            while (counter < 0);

        }
    }
}
