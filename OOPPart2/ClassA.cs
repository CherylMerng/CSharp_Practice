using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    internal class ClassA : MyAbstractClass, IShape
    {
        // 5 - Interface

        private int myNumber;
        public int MyNumber {
            get { return myNumber; }
            set { 
                if (value < 0)
                    myNumber = 0;
                else
                    myNumber = value;
            }
        }

        int IShape.myNumber { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public void InterfaceMethod() {
            Console.WriteLine("The number is {0}.", MyNumber);
        }


        // 4 - Abstract Class

        public override void PrintMessageAbstract()
        {
            Console.WriteLine("C# is fun!");
        }

        void IShape.InterfaceMethod()
        {
            throw new NotImplementedException();
        }
    }
}
