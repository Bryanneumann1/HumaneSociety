using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class UI
    {
        Customer customer = new Customer();
        Animal animal = new Animal();
        public void Run()
        {
            
            string choice;
            Console.WriteLine("Enter 1 if you want to log in as a Humane Society Employee.");
            Console.WriteLine("Enter 2 if you are a customer creating a Profile");
            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "1":
                    EmployeeLogIn();
                    break;
                case "2":
                    customer.AddCustomer();
                    break;
            }

        }
        public void EmployeeLogIn()
        {
            //password is humanesociety
            string password;
            Console.WriteLine("Please Enter the Humane Society login password");
            password = Console.ReadLine().ToString();
            {
                if (password == "humanesociety")
                {
                    Console.Clear();
                    GetEmployeeOptions();
                }
               else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The Password you entered is incorrect\n");
                    Console.ResetColor();
                    Run();
                }
            }


        }
        public void GetEmployeeOptions()
        {
           
            Console.WriteLine("Here you will be able to enter new animals into the database.");
            Console.WriteLine("Enter 1 to Add a new animal to the database");
            Console.WriteLine("Enter 2 to Update an animals Adoption Status");
            Console.WriteLine("Enter 3 to Update an animals Shots");
            Console.WriteLine("Enter 4 to Update an animals weekly Food consumtion");
            Console.WriteLine("Enter 5 to search by adoption status");
            Console.WriteLine("Enter 6 to search for all animals that need their shots updated");
            Console.WriteLine("Enter 7 to search animals by Gender");
            Console.WriteLine("Enter 8 to search by Activity requirements");
            Console.WriteLine("Enter 9 to search for occupied rooms");
            Console.WriteLine("Enter EXIT to leave this application");
            
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    animal.AdoptionRules();
                    break;
                case "2":
                    Console.Clear();
                    animal.UpdateAdoptionStatus();
                    break;
                case "3":
                    Console.Clear();
                    animal.UpdateShotStatus();
                    break;
                case "4":
                    Console.Clear();
                    animal.UpdateFoodStatus();
                    break;
                case "5":
                    Console.Clear();
                    animal.SearchAnimalsByAdoptionStatus();
                    break;
                case "6":
                    Console.Clear();
                    animal.SearchAnimalsWithOutShots();
                    break;
                case "7":
                    Console.Clear();
                    animal.SearchAnimalsByGender();
                    break;
                case "8":
                    Console.Clear();
                    animal.SearchByActivityLevel();
                    break;
                case "9":
                    Console.Clear();
                    animal.SearchForOccupiedRooms();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    Run();
                    break;

            }
        }
    }
}
