using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _11_Math
    {
        public static void _Math() {
            Console.WriteLine(Math.Round(19.5));

            double x = 19.5555;
            Console.WriteLine(Math.Round(x, 2));

            Console.WriteLine(Math.Ceiling(19.1));
            Console.WriteLine(Math.Ceiling(19.9));
            Console.WriteLine(Math.Floor(19.1));
            Console.WriteLine(Math.Floor(19.9));
        }
    }
}
