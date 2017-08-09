using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    partial class Customer
    {
        AnimalDatabaseDataContext database = new AnimalDatabaseDataContext();

        public void AddCustomer()
        {
            Customer customer = new Customer();
            Console.WriteLine("You will need to enter information about the customer adopting a pet.");
            Console.WriteLine("First Name: ");
            customer.First_Name = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            customer.Last_Name = Console.ReadLine();

            Console.WriteLine("Address: ");
            customer.Address_ = Console.ReadLine();

            Console.WriteLine("Phone Number: ");
            customer.Phone_Number = Console.ReadLine();

            database.Customers.InsertOnSubmit(customer);
            database.SubmitChanges();


        }
    }
}
