using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Basics
{
    internal class _03_Array
    {
        public static void _Array() {

            // 3.1 Array

            // a collection of data that are normally related to each other
            // [] = array

            // declare => new operator
            int[] userAge1 = new int[] { 5 };
            // initalize
            userAge1 = new[] { 21, 22, 23, 24, 25 };

            // declare and initialze
            int[] userAge = { 21, 22, 23, 24, 25 };

            // Individual values in the array are accessible by their indexes,
            // and indexes always start with a value of ZERO, not 1.

            Console.WriteLine(userAge[2]);

            userAge[2] = userAge[2] + 20;
            Console.WriteLine(userAge[2]);

            // 3.2 Array Property - .length

            Console.WriteLine(userAge.Length);

            // 3.3 Array Methods - Copy(), Sort(), IndexOf()

            int[] source = { 12, 1, 5, -2, 16, 14 };
            int[] dest = { 1, 2, 3, 4 };

            // copy the first three elements of 'source' into 'dest'
            // dest array becomes {12, 1, 5, 4} while source array remains unchanged
            Array.Copy(source, dest, 3);

            Console.WriteLine(source.Length);
            Console.WriteLine(dest.Length);


            int[] numbers = { 12, 1, 5, -2, 16, 14 };
            Array.Sort(numbers);    // {-2, 1, 5, 12, 14, 16}

            int[] numbers1 = { 10, 30, 44, 21 };

            int[] numbers2 = { 10, 30, 44, 21, 51, 21, 61, 24, 14 };
            Array.IndexOf(numbers2, 21);    // 3 - returns the index of the first value found

            int ans = Array.IndexOf(numbers2, 21);
            Console.WriteLine(ans);
            ans = Array.IndexOf(numbers2, 100);
            Console.WriteLine(ans);     // -1 = does not exist
           

        }
    }
}
