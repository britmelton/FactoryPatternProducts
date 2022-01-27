using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product() { Name = "Sailor Moon Doll", Price = 29.99m }
        };

        public List <Product> LoadData()
        {

            Console.WriteLine($"I am reading from Mongo Data Access type.");
            return products;  
        }

        public void SaveData()
        {
      
            Console.WriteLine($"I am saving data to MongoDataAccess");
        }
    }
}
