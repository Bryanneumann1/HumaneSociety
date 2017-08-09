﻿using System;
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
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "1":
                    animal.AddAnimal();
                    break;
                case "2":
                    customer.AddCustomer();
                    break;
                default:
                    Run();
                    break;

            }
        }
    }
}