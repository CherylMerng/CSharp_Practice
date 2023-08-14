using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    // 1 - Inheritance
    internal class NormalMember : Member
    {
        // first way
        public NormalMember()
        {
            Console.WriteLine("Child constructor with no parameter");
        }

        // second way – to call non parameterless constructor in parent’s class
        /*public NormalMember(string remarks) : base("Jamie", 1, 2015)
        {
            Console.WriteLine("Remarks = {0}", remarks);
        }*/

        // better way for second
        public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        // 2 - Polymorphism
        // added override keyword for polymorphism

        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }

    }
}
