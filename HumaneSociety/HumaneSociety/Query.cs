using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Query
    {
        public void Run()
        {
            AnimalDatabaseDataContext database = new AnimalDatabaseDataContext();
            var animals =
                from x in database.Animals
                select x;
            foreach (var x in animals)
            {
                Console.WriteLine("Breed: " + x.Breed);
                Console.WriteLine("Name: " + x.Name);
                Console.WriteLine("ID#: " + x.Id);
                Console.WriteLine("Species: " + x.Animal_Type);
                Console.WriteLine("Room #: " + x.Room);
                Console.WriteLine("Age: " + x.Age);
                Console.WriteLine("Shots: " + x.Shots);
                Console.WriteLine("Food: " + x.Food);
                Console.WriteLine("Status: " + x.Adoption_Status);
            }

        }
    }
}
