using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStructLinqFileHandling
{
    enum Days { Mon, Tue, Wed }

    class AnotherClass {
        public int number;
    }

    internal class _02_Struct
    {
        public struct MyStruct {

            // fields
            private int x, y;
            private AnotherClass myClass;
            private Days myDays;

            // Constuctor
            public MyStruct(int a, int b, int c) { 
                myClass = new AnotherClass();
                myClass.number = a;
                x = b;
                y = c;
                myDays = Days.Mon;
                
            }

            // Method
            public void PrintStatement() {
                Console.WriteLine("x = {0}, y = {1}, myDays = { 2}", x, y, myDays);
            }         
            
        }

    }
}
