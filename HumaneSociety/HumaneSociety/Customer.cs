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
            AddCustomerFirstName(customer);
            AddCustomerLastName(customer);
            AddCustomerAddress(customer);
            AddCustomerPhoneNumber(customer);
            AddCustomerActivityLevel(customer);
            AddCustomerHousing(customer);
            AddCustomerOwnOrRent(customer);
            AddCustomerOccupation(customer);
            AddCustomerSalary(customer);
            SubmitData(customer);
        }
        public void AddCustomerFirstName(Customer customer)
        {
            string firstName;
            Console.WriteLine("You will need to enter information about the customer adopting a pet.");
            Console.WriteLine("First Name: ");
            firstName = Console.ReadLine().ToLower();
            if (firstName == "")
            {
                AddCustomerFirstName(customer);
            }
            else
            {
                customer.First_Name = firstName.ToString();
            }  
        }
        public void AddCustomerLastName(Customer customer)
        {
            string lastName;
            Console.WriteLine("Last Name: ");
            lastName = Console.ReadLine().ToLower();
            if (lastName == "")
            {
                AddCustomerLastName(customer);
            }
            else
            {
                customer.Last_Name = lastName.ToString();
            }
        }
        public void AddCustomerAddress(Customer customer)
        {
            string address;
            Console.WriteLine("Address: ");
            address = Console.ReadLine().ToLower();
            if(address == "")
            {
                AddCustomerAddress(customer);
            }
            else
            {
                customer.Address_ = address.ToString();
            }
        }
        public void AddCustomerPhoneNumber(Customer customer)
        {
            string phoneNumber;
            Console.WriteLine("Phone Number: ");
            phoneNumber = Console.ReadLine().ToLower();
            if(phoneNumber == "")
            {
                AddCustomerPhoneNumber(customer);
            }
            else
            {
                customer.Phone_Number = phoneNumber.ToString();
            }
            
        }
        public void AddCustomerActivityLevel(Customer customer)
        {
            string activity;
            Console.WriteLine("Activity level (Low),(Medium), or (High): ");
            activity = Console.ReadLine().ToLower();
            if (activity != "low" && activity != "medium" && activity != "high")
            {
                AddCustomerActivityLevel(customer);
            }
            else
            {
                customer.Activity_Level = activity.ToString();
            }
            
        }
        public void AddCustomerHousing(Customer customer)
        {
            string housing;
            Console.WriteLine("Do you live in a House , Condo, or Appartment: ");
            housing = Console.ReadLine().ToLower();
            if(housing != "house" && housing != "condo" && housing != "appartment")
            {
                AddCustomerHousing(customer);
            }
            else
            {
                customer.Housing = housing.ToString();
            }
        }
        public void AddCustomerOwnOrRent(Customer customer)
        {
            string ownRent;
            Console.WriteLine("Own or Rent: ");
            ownRent = Console.ReadLine().ToLower();
            if (ownRent != "own" && ownRent != "rent")
            {
                AddCustomerOwnOrRent(customer);
            }
            else
            {
                customer.Own_Rent = ownRent.ToString();
            }
            
        }
        public void AddCustomerOccupation(Customer customer)
        {
            string occupation;
            Console.WriteLine("Occupation: ");
            occupation = Console.ReadLine().ToString();
            if (occupation == "")
            {
                AddCustomerOccupation(customer);
            }
            else
            {
                customer.Occupation = occupation.ToString();
            }
            
        }
        public void AddCustomerSalary(Customer customer)
        {
            string salary;
            Console.WriteLine("Annual Salary: ");
            salary = Console.ReadLine().ToLower();
            if(salary == "")
            {
                AddCustomerSalary(customer);
            }
            else
            {
                customer.Annual_Income = salary.ToString();
            }
        }
        public void SubmitData(Customer customer)
        {
            database.Customers.InsertOnSubmit(customer);
            database.SubmitChanges();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thank you for creating a profile, It has been submited into the system");
            Console.ResetColor();
            Console.WriteLine("Please press enter to return to the main menu");
        }
    }
}
