using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Query
    {
        AnimalDatabaseDataContext database = new AnimalDatabaseDataContext();
        Animal newAnimal = new Animal();
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

            Console.WriteLine("Room #: ");
            newAnimal.Room = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adoption status: ");
            newAnimal.Adoption_Status = Console.ReadLine();
        }

        public void AddToDatabase()
        {
            database.Animals.InsertOnSubmit(newAnimal);
            database.SubmitChanges();
        }
    }
}
