using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Basics
{
    internal class _05_List
    {
        public static void _List() {

        // 5.1 List
            // A list stores values like an array,
            // but elements can be added or removed at will.

            // declare
            List<int> userAgeList1 = new List<int>();
            // initialize
            List<int> userAgeList = new List<int> { 11, 21, 31, 41 };
            // access
            Console.WriteLine(userAgeList[3]);

         // 5.2 List properties - .Count
            Console.WriteLine(userAgeList.Count);   // 4

         // 5.3 List Methods - Add(), Insert(), Remove(), RemoveAt(), Contains(), Clear()

            userAgeList.Add(51);
            Console.WriteLine(userAgeList.Count);   // 5

            userAgeList.Insert(0, 1);
            Console.WriteLine(userAgeList[0]);  // 1
            Console.WriteLine(userAgeList.Count);   // 6

            userAgeList.Remove(41);   // { 1, 11, 21, 31, 51 }

            userAgeList.RemoveAt(3);  // { 1, 11, 21, 51 }
            Console.WriteLine(userAgeList.Count);   // 4

            Console.WriteLine(userAgeList.Contains(31));    // false

            userAgeList.Clear();
            Console.WriteLine(userAgeList.Count);   // 0

        }
    }
}
