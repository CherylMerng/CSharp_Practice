using OOPPart1;
using System.Diagnostics.Metrics;

// 1 - Classes and Objects
int pay;

Staff staff1 = new Staff("Peter");
staff1.HoursWorked = 160;
pay = staff1.CalculatePay(1000, 400);
Console.WriteLine("Pay = {0}", pay);

Staff staff2 = new Staff("Jane", "Lee");
staff2.HoursWorked = 160;
pay = staff2.CalculatePay();
Console.WriteLine("Pay = {0}", pay);

Staff staff3 = new Staff("Carol");
staff3.HoursWorked = -10;
pay = staff3.CalculatePay();
Console.WriteLine("Pay = {0}", pay);


// 2 - Static
// non static members
MyClass classA = new MyClass();
Console.WriteLine(classA.message);
classA.Name = "Susan";
classA.DisplayName();

// static members
Console.WriteLine(MyClass.greetings);
MyClass.Age = 39;
MyClass.DisplayAge();

int b = MyStaticClass.B = 2;
Console.WriteLine($"B = {b}");


// 3 - Advanced Method Concept

// array and list
int[] myArray = { 1, 2, 3, 4, 5 };
AdvancedMethodConcept.PrintFirstElement(myArray);

List<int> myList = new List<int> { 1, 2, 3 };
AdvancedMethodConcept.PrintFirstElement(myList);

int[] myArray2 = AdvancedMethodConcept.ReturnUserInput();
Console.WriteLine($"{myArray2[0]}, {myArray2[1]}, {myArray2[2]}");

List<int> myList2 = AdvancedMethodConcept.ReturnUserInputAsList();
Console.WriteLine($"{myList2[0]}, {myList2[1]}, {myList2[2]}");

// params
AdvancedMethodConcept.PrintNames("Peter");
AdvancedMethodConcept.PrintNames("Yvonne", "Jamie");
AdvancedMethodConcept.PrintNames("Abigail", "Betty", "Carol", "David");


// 4 - Pass value type vs. reference type parameters

int A = 2;
int[] B = { 1, 2, 3 };
MethodDemo obj = new MethodDemo();

Console.WriteLine("a before = {0}", A);
obj.PassByValue(A);
Console.WriteLine("a after = {0}", A);

Console.WriteLine("b[0] before = {0}", B[0]);
obj.PassByReference(B);
Console.WriteLine("b[0] after = {0}", B[0]);