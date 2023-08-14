using OOPPart2;

// 1 - Inheritance

/*
NormalMember mem1 = new NormalMember("Special Rate", "James", 1, 2010);
VIPMember mem2 = new VIPMember("Andy", 2, 2011);

mem1.CalculateAnnualFee();
mem2.CalculateAnnualFee();

Console.WriteLine(mem1.ToString());
Console.WriteLine(mem2.ToString());
*/

// 2 - Polymorphism

/*
Member[] clubMembers = new Member[5];
clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
clubMembers[3] = new VIPMember("Carol", 4, 2012);
clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

foreach (Member m in clubMembers)
{
    m.CalculateAnnualFee();
    Console.WriteLine(m.ToString());
}
*/

// 3 - GetType() and typeOf()

/*
if (clubMembers[0].GetType() == typeof(VIPMember))
    Console.WriteLine("\nTrue");
else
    Console.WriteLine("\nFalse");
*/

// 4 - Abstract Class
ClassA a = new ClassA();
a.PrintMessage();
a.PrintMessageAbstract();

// 5 - Interface
a.MyNumber = 5;
a.InterfaceMethod();

Console.Read();