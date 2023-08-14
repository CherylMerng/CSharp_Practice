using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1
{
    // 1 - Classes and Objects

    internal class Staff    // class
    {
        // field
        private string staffName;
        private const int hourlyRate = 30;
        private int hWorked;


        // property
        public int HoursWorked { 
            get { return hWorked; }
            set { 
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }


        // auto-implemented property
        // public int HoursWorked { get; set; }
        //public int HoursWorked { get; private set; }


        // constructor
        public Staff(string name) { 
            staffName = name;
            Console.WriteLine(staffName);
        }

        public Staff(string firstName, string lastName) { 
            staffName = firstName + " " + lastName;
            Console.WriteLine(staffName);
        }


        // method
        public void PrintMessage() { }

        public int CalculatePay() { 
            PrintMessage();

            int staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else 
                return 0;
        }

        // method overloading
        public int CalculatePay(int bonus, int allowance) {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

        // ToString()
        public override string ToString() {
            return "Staff Name = " + staffName + ", Hourly Rate = " + hourlyRate + ", Hours Worked = " + hWorked;
        }

    }
}
