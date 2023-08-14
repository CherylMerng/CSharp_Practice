using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStructLinqFileHandling
{
    enum DaysOfWeek { Sun, Mon, Tue, Wed, Thu, Fri, Sat }

    enum DaysOfWeek2 { Sun = 5, Mon = 10, Tue, Wed, Thu, Fri, Sat }

    enum DaysOfWeek3 : byte { Sun = 100, Mon = 200, Tue, Wed, Thu, Fri, Sat }
    // byte 0~255

    internal class _01_Enum
    {
        public static void _Enum() {
            
            DaysOfWeek myDays = DaysOfWeek.Mon;
            Console.WriteLine(myDays);

            Console.WriteLine((int)DaysOfWeek.Mon);   // 1
            Console.WriteLine((int)myDays);   // 1

            Console.WriteLine((DaysOfWeek)1);   // Mon


            Console.WriteLine((DaysOfWeek2)11);     // Tue


        }
    }
}