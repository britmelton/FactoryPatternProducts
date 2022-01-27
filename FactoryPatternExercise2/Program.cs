using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use: List, SQL, or Mongo?");
            string dataBaseType = Console.ReadLine();    
            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(dataBaseType);

            List<Product> products = dataAccess.LoadData();
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}\nPrice:{product.Price}");
            }
       
            dataAccess.SaveData();

          
           

        }
    }
}
