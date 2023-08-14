using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1
{
    // 3 - AdvancedMethodConcept - using array, list and params
    internal static class AdvancedMethodConcept
    {
        // array and list
        public static void PrintFirstElement(int[] a)
        {
            Console.WriteLine("The first element is {0}.\n", a[0]);
        }

        public static void PrintFirstElement(List<int> a)
        {
            Console.WriteLine("The first element is {0}.\n", a[0]);
        }

        public static int[] ReturnUserInput()
        {
            int[] a = new int[3];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter an integer: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }

        public static List<int> ReturnUserInputAsList()
        {
            List<int> a = new List<int>();
            int input;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter an integer: ");
                input = Convert.ToInt32(Console.ReadLine());
                a.Add(input);
            }
            return a;
        }

        // params
        public static void PrintNames(params string[] names) {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintNames2(int a, double b, params int[] ages) { }

    }
}
