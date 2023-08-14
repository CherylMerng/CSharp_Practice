using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    // 6 - Access Modifiers
    internal class Class3
    {
        Class1 c1 = new Class1();

        public void PrintMessages() {
            // This is ok
            Console.WriteLine(c1.publicNum);

            // This is not ok
            // Console.WriteLine(c1.protectedNum);

            // This is not ok
            // Console.WriteLine(c1.privateNum);
        }
    }
}
