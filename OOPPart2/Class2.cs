using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    // 6 - Access Modifiers
    internal class Class2 : Class1
    {
        public void PrintMessages() {
            // This is ok
            Console.WriteLine(publicNum);

            // This is ok
            Console.WriteLine(protectedNum);

            // This is not ok
            // Console.WriteLine(privateNum);
        }
    }
}
