using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowStatements
{
    internal class _06_While
    {
        public static void _While() {

            int counter = 5;

            while (counter > 0)
            {

                Console.WriteLine("Counter = {0}", counter);
                counter--;

            }
        }
    }
}
