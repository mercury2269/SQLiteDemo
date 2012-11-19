using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteDemo.Data;
using SQLiteDemo.Model;

namespace SQLiteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository rep = new SqLiteCustomerRepository();
            var customer = new Customer
                {
                    FirstName = "Sergey",
                    LastName = "Maskalik",
                    DateOfBirth = DateTime.Now
                };
            rep.SaveCustomer(customer);

            Customer retrievedCustomer = rep.GetCustomer(customer.Id);
        }
    }
}
