using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowStatements
{
    internal class _09_Continue
    {
        public static void _Continue() {

            for (int i = 0; i < 5; i++) {
                
                if (i == 2)
                    continue;

                Console.WriteLine("i = {0}", i);
                Console.WriteLine("i will not be printed if i=2.\n");
            }
        }
    }
}
