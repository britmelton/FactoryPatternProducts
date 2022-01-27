using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product() { Name = "Studio Ghibli DVD set", Price = 99.99m}
        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading from SQLDataAccess.");
            return products;
        }

        public void SaveData()
        {
            
            Console.WriteLine($"I am saving data to SQLDataAccess.");
        }
    }
}
