using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
   partial class Animal
    {
        AnimalDatabaseDataContext database = new AnimalDatabaseDataContext();
        Animal newAnimal = new Animal();
        Room_Number newroomnumber = new Room_Number();
        public void Run()
        {

            AddAnimal();

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

            //Animal newAnimal = new Animal();
            //Room_Number newroomnumber = new Room_Number();
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

            Console.WriteLine("Activity level (Low),(Medium), or (High)");
            newAnimal.Activity_Level = Console.ReadLine();

            Console.WriteLine("Room #: ");
            newroomnumber.RoomNumber = Convert.ToInt32(Console.ReadLine());
            newAnimal.Room_Number = newroomnumber;

            Console.WriteLine("Adoption status: ");
            newAnimal.Adoption_Status = Console.ReadLine();

            Console.WriteLine("What is the adoption fee for this animal?");
            try
            {
                newAnimal.Price = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("please enter the price in decimal format");
            }
            database.Animals.InsertOnSubmit(newAnimal);
         
            database.SubmitChanges();
        }

        public void UpdateAdoptionStatus()
        {
            string nameinput;
            int idinput;
            Console.WriteLine("Please enter the animals Id number that you would like to update");
            idinput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the animals name that you would like to Update");
            nameinput = Console.ReadLine();

            var animals = database.Animals.Where(x => x.Name == nameinput && x.Id == idinput);

            foreach (var x in animals)
            {
                if (x.Id != idinput || x.Name != nameinput)
                    Console.WriteLine("That animal doesnt exist");
                else
                {
                    x.Adoption_Status = "Adopted";
                    database.SubmitChanges();

                    Console.WriteLine("Updated");
                }
            }
        }
        public void UpdateShotStatus()
        {
            int idinput;
            Console.WriteLine("Please enter the Id number of the animal that you are administering shots to");
            idinput = Convert.ToInt32(Console.ReadLine());

            var animals = database.Animals.Where(x => x.Id == idinput);

            foreach (var x in animals)
            {
                if (x.Id != idinput || x.Shots != "no")
                    Console.WriteLine("Please enter an animal that needs its shots updated");

                else
                {
                    x.Shots = "Yes";
                    database.SubmitChanges();

                    Console.WriteLine("Updated");
                }
            }
        }
        public void UpdateFoodStatus()
        {
            string food;
            int idinput;
            Console.WriteLine("Please enter the Id for the animals Food status you would like to update");
            idinput = Convert.ToInt32(Console.ReadLine());

            var animals = database.Animals.Where(x => x.Id == idinput);

            foreach (var x in animals)
            {
                if (x.Id != idinput)
                    Console.WriteLine("That animal doesn't exist");
                else
                {
                    Console.WriteLine("What is the animals new weekly food consumtion?");
                    food = Console.ReadLine();
                    x.Food = food;
                    database.SubmitChanges();
                    Console.WriteLine("Updated");
                }
            }
        }
        public void SearchAnimalsWithOutShots()
        {
            var animals = database.Animals.Where(x => x.Shots == "no");

            foreach (var x in animals)
            {
                Console.WriteLine("Id: " + x.Id.ToString());
                Console.WriteLine("Gender: " + x.Gender);
                Console.WriteLine("Name: " + x.Name);
                Console.WriteLine("Breed: " + x.Breed);
                Console.WriteLine("Age: " + x.Age);
                Console.WriteLine("Adoption status: " + x.Adoption_Status);
                Console.WriteLine("Up to date on shots: " + x.Shots);
                Console.WriteLine("Weekly diet: " + x.Food);
                Console.WriteLine(" ");
            }
                
        }

        public void SearchAnimalsByAdoptionStatus()
        {
            string input;
            Console.WriteLine("Please enter (Adopted) to search for all adopted animals\n" +
                "Please enter (Available) to search all available animals.");
            input = Console.ReadLine().ToLower();
            var animals = database.Animals.Where(x => x.Adoption_Status == input);
            if (input != "adopted" && input != "available")
            {
                Console.WriteLine("There are no animals that meet that criteria");
                SearchAnimalsByAdoptionStatus();
            }
            foreach (var x in animals)
            {
                Console.WriteLine("Id: " + x.Id.ToString());
                Console.WriteLine("Gender: " + x.Gender);
                Console.WriteLine("Name: " + x.Name);
                Console.WriteLine("Breed: " + x.Breed);
                Console.WriteLine("Age: " + x.Age);
                Console.WriteLine("Adoption status: " + x.Adoption_Status);
                Console.WriteLine("Up to date on shots: " + x.Shots);
                Console.WriteLine("Weekly diet: " + x.Food);
                Console.WriteLine(" ");
            }
        }

        public void SearchAnimalsByGender()
        {
            string input;
            Console.WriteLine("Enter (male) to search for all male animals\n" +
                "Enter (female) to search for all female animals");
            input = Console.ReadLine().ToLower();
            var animals = database.Animals.Where(x => x.Gender == input);
            if (input != "male" && input != "female")
            {
                Console.WriteLine("There are no animals that meet that search criteria");
                SearchAnimalsByGender();
            }
            foreach (var x in animals)
            {
                Console.WriteLine("Id: " + x.Id.ToString());
                Console.WriteLine("Gender: " + x.Gender);
                Console.WriteLine("Name: " + x.Name);
                Console.WriteLine("Breed: " + x.Breed);
                Console.WriteLine("Age: " + x.Age);
                Console.WriteLine("Adoption status: " + x.Adoption_Status);
                Console.WriteLine("Up to date on shots: " + x.Shots);
                Console.WriteLine("Weekly diet: " + x.Food);
                Console.WriteLine(" ");
            }
        }

        public void SearchByActivityLevel()
        {
            string input;
            Console.WriteLine("Please enter the activity level of the animal you would like to search (Low), (Medium), or (High)");

            input = Console.ReadLine().ToLower();
            var animals = database.Animals.Where(x => x.Activity_Level == input);
            if(input != "low" && input != "medium" && input != "high")
            {
                Console.WriteLine("There are no animals that meet that search criteria");
                SearchByActivityLevel();
            }
            foreach (var x in animals)
            {
                Console.WriteLine("Id: " + x.Id.ToString());
                Console.WriteLine("Gender: " + x.Gender);
                Console.WriteLine("Name: " + x.Name);
                Console.WriteLine("Breed: " + x.Breed);
                Console.WriteLine("Age: " + x.Age);
                Console.WriteLine("Adoption status: " + x.Adoption_Status);
                Console.WriteLine("Up to date on shots: " + x.Shots);
                Console.WriteLine("Weekly diet: " + x.Food);
                Console.WriteLine(" ");
            }

        }
        //public void SearchForMultipleCriteria()
        //{
        //    string gender;
        //    string breed;
        //    string type;
        //    string activityLevel;
        //    Console.WriteLine("Please enter the type of animal you would like to search for");
        //    type = Console.ReadLine().ToLower();
        //    Console.WriteLine("Please enter the breed of animal you would like to serch for");
        //    breed = Console.ReadLine().ToLower();
        //    Console.WriteLine("Enter (male) to search for all male animals\n" +
        //        "Enter (female) to search for all female animals");
        //    gender = Console.ReadLine().ToLower();
        //    Console.WriteLine("Please enter the activity level of the animal you would like to search (Low), (Medium), or (High)");
        //    activityLevel = Console.ReadLine().ToLower();
        //}
        public void SearchForOccupiedRooms()
        {
            var rooms = database.Room_Numbers.Where(x => x.RoomNumber == x.RoomNumber);


            foreach (var x in rooms)
            {
                Console.WriteLine(x.RoomNumber);
            }
        }
        public void SearchByAnimalType()
        {
            string input;
            Console.WriteLine("Please enter the Type of animal you would like to search for");
            input = Console.ReadLine().ToLower();

            var animal = database.Animals.Where(x => x.Animal_Type == input);
            if (input != "dog" && input != "cat" && input != "bird" && input != "rabbit" && input != "guinea pig")
            {
                Console.WriteLine("There are no animals that meet that criteria");
                SearchByAnimalType();
            }
            foreach(var x in animal)
            {
                Console.WriteLine("Id: " + x.Id.ToString());
                Console.WriteLine("Gender: " + x.Gender);
                Console.WriteLine("Name: " + x.Name);
                Console.WriteLine("Breed: " + x.Breed);
                Console.WriteLine("Age: " + x.Age);
                Console.WriteLine("Adoption status: " + x.Adoption_Status);
                Console.WriteLine("Up to date on shots: " + x.Shots);
                Console.WriteLine("Weekly diet: " + x.Food);
                Console.WriteLine(" ");
            }
        }
    }
}
