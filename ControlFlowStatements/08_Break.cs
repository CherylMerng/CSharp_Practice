using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowStatements
{
    internal class _08_Break
    {
        public static void _Break() {
            int i = 0;

            for (i = 0; i < 5; i++) {
                Console.WriteLine("i = {0}", i);
                if (i == 2)
                    break;
            }
        }
    }
}
