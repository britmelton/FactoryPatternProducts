using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
          new Product() { Name = "BTS Summer Package", Price = 199.00m}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading from ListDataAccess.");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to ListDataAccess.");
        }
    }
}
