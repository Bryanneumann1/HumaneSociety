using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class UI
    {
        public void Run()
        {
            Customer customer = new Customer();
            Animal animal = new Animal();
            Console.WriteLine("Here you will be able to enter new animals and customers.");
            Console.WriteLine("Enter 1 to Add a new animal to the database");
            Console.WriteLine("Enter 2 to Add a new customer to the database");
            Console.WriteLine("Enter 3 to Update an animals Adoption Status");
            Console.WriteLine("Enter 4 to Update an animals Shots");
            Console.WriteLine("Enter 5 to Update an animals weekly Food consumtion");
            Console.WriteLine("Enter 6 to search for all animals that have been adoption");
            Console.WriteLine("Enter 7 to search for all animals that are available for adoption");
            Console.WriteLine("Enter 8 to search for all animals that are up to date on shots");
            Console.WriteLine("Enter 9 to search for all animals that are not up to date on shots");
            Console.WriteLine("Enter 10 to search for all male animals");
            Console.WriteLine("Enter 11 to search for all female animals");
            Console.WriteLine("Enter EXIT to leave this application");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "1":
                    animal.AddAnimal();
                    break;
                case "2":
                    customer.AddCustomer();
                    break;
                case "3":
                    animal.UpdateAdoptionStatus();
                    break;
                case "4":
                    animal.UpdateShotStatus();
                    break;
                case "5":
                    animal.UpdateFoodStatus();
                    break;
                case "6":
                    animal.SearchAnimalsAdopted();
                    break;
                case "7":
                    animal.SearchAnimalsAvailble();
                    break;
                case "8":
                    animal.SearchAnimalsWithShots();
                    break;
                case "9":
                    animal.SearchAnimalsWithOutShots();
                    break;
                case "10":
                    animal.SearchByMaleGender();
                    break;
                case "11":
                    animal.SearchByFemaleGender();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Run();
                    break;

            }
        }
    }
}
