using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public partial class Customer
    {
        AnimalDatabaseDataContext database = new AnimalDatabaseDataContext();

        public void AddCustomer()
        {
            Customer customer = new Customer();
            Console.WriteLine("You will need to enter information about the customer adopting a pet.");
            Console.WriteLine("First Name: ");
            customer.First_Name = Console.ReadLine().ToString();

            Console.WriteLine("Last Name: ");
            customer.Last_Name = Console.ReadLine().ToString();

            Console.WriteLine("Address: ");
            customer.Address_ = Console.ReadLine().ToString();

            Console.WriteLine("Phone Number: ");
            customer.Phone_Number = Console.ReadLine().ToString();

            Console.WriteLine("Activity level (Low),(Medium), or (High): ");
            customer.Activity_Level = Console.ReadLine().ToString();

            Console.WriteLine("House , Condo, or Appartment: ");
            customer.Housing = Console.ReadLine().ToString();

            Console.WriteLine("Own or Rent: ");
            customer.Own_Rent = Console.ReadLine().ToString();

            Console.WriteLine("Occupation: ");
            customer.Occupation = Console.ReadLine().ToString();

            Console.WriteLine("Annual Salary: ");
            customer.Annual_Income = Console.ReadLine().ToString();

            database.Customers.InsertOnSubmit(customer);
            database.SubmitChanges();
        }

    }
}
