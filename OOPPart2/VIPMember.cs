using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    // 1 - Inheritance
    internal class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince)
            : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 3 parameters");
        }

        // 2 - Polymorphism
        // added override keyword for polymorphism
        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }

    }
}
