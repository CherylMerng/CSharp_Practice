using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{

    // 1 - Inheritance
    internal class Member
    {
        private string name;
        private int memberID;
        private int memberSince;
        protected int annualFee;

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameter");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }

        // 2 - Polymorphism
        // added the whole method for polymorphism
        public virtual void CalculateAnnualFee() 
        {           
            annualFee = 0;
        }

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID +
            "\nMember Since:  " + memberSince + "\nTotal Annual Fee: " + annualFee;
        }

    }
}
