using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowStatements
{
    internal class _03_Switch
    {
        public static void _Switch() {

            Console.WriteLine("Enter your grade: ");
            string userGrade = Console.ReadLine()!;

            switch (userGrade) {
                case "A+":
                case "A":
                    Console.WriteLine("Distinction");
                    break;
                case "B":
                    Console.WriteLine("Grade B");
                    break;
                case "C":
                    Console.WriteLine("Grade C");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;

            }
        }
    }
}
