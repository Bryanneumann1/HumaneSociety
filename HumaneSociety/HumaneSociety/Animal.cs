﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    partial class Animal
    {
        AnimalDatabaseDataContext database = new AnimalDatabaseDataContext();
        
        public void Run()
        {
            
            AddAnimal();
            AddToDatabase();
            //var animals =
            //    from x in database.Animals
            //    select x;
            //foreach (var x in animals)
            //{
            //    Console.WriteLine("Breed: " + x.Breed);
            //    Console.WriteLine("Name: " + x.Name);
            //    Console.WriteLine("ID#: " + x.Id);
            //    Console.WriteLine("Species: " + x.Animal_Type);
            //    Console.WriteLine("Room #: " + x.Room);
            //    Console.WriteLine("Age: " + x.Age);
            //    Console.WriteLine("Shots: " + x.Shots);
            //    Console.WriteLine("Food: " + x.Food);
            //    Console.WriteLine("Status: " + x.Adoption_Status);
            //}

        }
        public void AddAnimal()
        {
            Animal newAnimal = new Animal();
            Room_Number newroomnumber = new Room_Number();
            Console.WriteLine("You will need to enter infomation about the animal you are submiting");
            Console.WriteLine("Animal Type: ");
            newAnimal.Animal_Type = Console.ReadLine();

            Console.WriteLine("Breed: ");
            newAnimal.Breed = Console.ReadLine();

            Console.WriteLine("Gender: ");
            newAnimal.Gender = Console.ReadLine();

            Console.WriteLine("Name: ");
            newAnimal.Name = Console.ReadLine();

            Console.WriteLine("Age: ");
            newAnimal.Age = Console.ReadLine();

            Console.WriteLine("Weekly Food Consumtion: ");
            newAnimal.Food = Console.ReadLine();

            Console.WriteLine("Up to date on shots?: ");
            newAnimal.Shots = Console.ReadLine();

            //Console.WriteLine("Room #: ");
            //newroomnumber.RoomNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adoption status: ");
            newAnimal.Adoption_Status = Console.ReadLine();

            database.Animals.InsertOnSubmit(newAnimal);
            database.SubmitChanges();

        }

        public void AddToDatabase()
        {

        }
    }
}