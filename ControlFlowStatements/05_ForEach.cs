using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowStatements
{
    internal class _05_ForEach
    {
        public static void _ForEach()
        {
            char[] message = { 'H', 'e', 'l', 'l', 'o'};

            foreach (char c in message) { 
                Console.WriteLine(c);   
            }
        }
    }
}
