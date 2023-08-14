using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _02_TypeCasting
    {
        public static void _TypeCasting() 
        {

            int x = (int)20.9;  // 20
            float y = (float)20.9;  // 20.9
            decimal z = (decimal)20.9;  // 20.9

            Console.WriteLine(x + ", " + y + ", " + z);

        }
    }
}
