using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EnumStructLinqFileHandling
{
    internal class _03_Linq
    {
        public static void _Linq()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            var evenNumQuery = 
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int i in evenNumQuery) { 
                Console.WriteLine("{0} is an even number", i);
            }

            Console.WriteLine("-----------------------------------");
            

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Alan", "80911291", "ABC Street", 25.60m));
            customers.Add(new Customer("Bill", "19872131", "DEF Street", -32.1m));
            customers.Add(new Customer("Carl", "29812371", "GHI Street", -12.2m));
            customers.Add(new Customer("David", "78612312", "JKL Street", 12.6m));

            var overdue =
                from cust in customers
                where cust.Balance < 0
                orderby cust.Balance ascending
                select new { cust.Name, cust.Balance };
            // new - select more than one field from object

            foreach (var cust in overdue)
                Console.WriteLine("Name = {0}, Balance = {1}", cust.Name, cust.Balance);
        }
    }

    public class Customer {

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }

        public Customer(String name, string phone, String address, decimal balance) { 
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.Balance = balance;
        }

        
    }
}
