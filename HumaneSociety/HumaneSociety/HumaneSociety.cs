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
        
        Room_Number newroomnumber = new Room_Number();
        public void AddAnimal()
        {
            UI ui = new UI();
           Animal newAnimal = new Animal();
            SetAnimalType(newAnimal);
            SetBreed(newAnimal);
            SetGender(newAnimal);
            SetName(newAnimal);
            SetAge(newAnimal);
            SetFoodConsumption(newAnimal);
            SetShotStatus(newAnimal);
            SetActivityLevel(newAnimal);
            SetRoomNumber(newAnimal);
            SetAdoptionStatus(newAnimal);
            SetAdoptionFee(newAnimal);
            SubmitChanges(newAnimal);
            ui.GetEmployeeOptions();
        }
        public void AdoptionRules()
        {
            
            Console.WriteLine("You will need to enter infomation about the animal you are submiting.\n");
            Console.WriteLine("Please read each question carefully and answer accordingly.\n");
            AddAnimal();
        }   
        public void SetAnimalType(Animal newAnimal)
        {
            string input;
            Console.WriteLine("This Humane Society is equipt to hold Dogs, Cats, Birds, Rabbits, and Guinea pigs\n");
            Console.WriteLine("Please enter the Animal Type: ");
            input = Console.ReadLine().ToLower();
            if (input != "dog" && input != "cat" && input != "bird" && input != "rabbit" && input != "guinea pig")
            {
            SetAnimalType(newAnimal);
            }
            else if(input == "back")
            {
                
            }
            else
            {
                newAnimal.Animal_Type = input.ToString();
            }
        }
        public void SetBreed(Animal newAnimal)
        {
            Console.WriteLine("Please enter the Breed of the animal that is being submitted: ");
            string breed;
            breed = Console.ReadLine();
            if (breed == "")
            {
                SetBreed(newAnimal);
            }
            else
            {
                newAnimal.Breed = breed.ToString();
            }
        }
        public void SetGender(Animal newAnimal)
        {
            string gender;
            Console.WriteLine("Please enter a Gender for the animal that is being submitted: ");
            gender = Console.ReadLine();
            if (gender == "")
            {
                SetGender(newAnimal);
            }
            else
            {
                newAnimal.Gender = gender.ToString();
            }
        }
        public void SetName(Animal newAnimal)
        {
            string name;
            Console.WriteLine("Please enter a Name for the animal that is being submitted");
            name = Console.ReadLine();
            if (name == "")
            {
                
                SetName(newAnimal);
            }
            else
            {
                newAnimal.Name = name.ToString();
            }

        }
        public void SetAge(Animal newAnimal)
        {
            string age;
            Console.WriteLine("Please enter the animals Age in month format if under 2 years old");
            Console.WriteLine("Age: ");
            age = Console.ReadLine();
            if (age == "")
            {
                SetAge(newAnimal);
            }
            else
            {
            newAnimal.Age = age.ToString();
            }
        }
        public void SetFoodConsumption(Animal newAnimal)
        {
            string food;
            Console.WriteLine("Please enter the animals Weekly Food Consumtion and Food type: ");
            food = Console.ReadLine();
            if (food == "")
            {
                SetFoodConsumption(newAnimal);
            }
            else
            {
                newAnimal.Food = food.ToString();
            }
        }
        public void SetShotStatus(Animal newAnimal)
        {
            string shots;
            Console.WriteLine("Please enter if the animal is Up to date on shots?\n(yes) or (no): ");
            shots = Console.ReadLine();
            if (shots == "")
            {
                SetShotStatus(newAnimal);
            }
            else
            {
                newAnimal.Shots = shots.ToString();
            }
        }
        public void SetActivityLevel(Animal newAnimal)
        {
            string activity;
            Console.WriteLine("Please enter animals activity level (Low),(Medium), or (High)");
            activity = Console.ReadLine().ToLower();
            if (activity != "low" && activity != "medium" && activity != "high")
            {
                SetActivityLevel(newAnimal);
            }
            else
            {
                newAnimal.Activity_Level = activity.ToString();
            }
        }
        public void SetRoomNumber(Animal newAnimal)
        {
            Console.WriteLine("Please enter the Room number the animal will be housed in.\nRoom #: ");
            try
            {
                newroomnumber.RoomNumber = Convert.ToInt32(Console.ReadLine());
                newAnimal.Room_Number = newroomnumber;
            }
            catch
            {
                Console.WriteLine("Please enter a valid room number");
                SetRoomNumber(newAnimal);
            }
        }
        public void SetAdoptionStatus(Animal newAnimal)
        {
            string status;
            
            Console.WriteLine("Please enter if the animal is (Adopted) or (Available)");
            Console.WriteLine("Adoption status: ");
            status = Console.ReadLine().ToLower();
            if (status != "adopted" && status != "available")
            {
                SetAdoptionStatus(newAnimal);
            }
            else
            {
                newAnimal.Adoption_Status = status.ToString();
            }
        }
        public void SetAdoptionFee(Animal newAnimal)
        {
            string price;
            Console.WriteLine("Please enter the Adoption fee for this animal?");
            price = Console.ReadLine();
            if (price == "")
            {
                SetAdoptionFee(newAnimal);
            }
            else
            {
                newAnimal.Price = price.ToString();
            }
        }
        public void SubmitChanges(Animal newAnimal)
        {
            database.Animals.InsertOnSubmit(newAnimal);

            database.SubmitChanges();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This Animal has been submitted into the Humane Society database");
            Console.ResetColor();
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
                    x.Price = "PAID";
                    database.SubmitChanges();

                    Console.WriteLine("Updated");
                    ResetRoomNumber();
                }
            }
        }
        public void ResetRoomNumber()
        {
            var animals = database.Animals.Where(x => x.Adoption_Status == "adopted");

            foreach(var x in animals)
            {
                x.RoomId = null;
                database.SubmitChanges();
            }
            Console.WriteLine("This room is now clean and ready for a new animal");
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
            if (input != "low" && input != "medium" && input != "high")
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
        public void SearchForOccupiedRooms()
        {
            var rooms = database.Room_Numbers.Where(x => x.RoomNumber == x.RoomNumber);
            foreach (var x in rooms)
                if (x.RoomNumber == x.RoomNumber)
                {
                    Console.WriteLine(x.RoomNumber);
                }
                else
                {
                    Console.WriteLine("All rooms are availalbe");
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
            foreach (var x in animal)
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
