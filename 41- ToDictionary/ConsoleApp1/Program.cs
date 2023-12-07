using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> 
            {
                new Product { ID = 1001,Name= "Mobile", Price = 800},
                new Product { ID = 1002,Name= "Laptop", Price = 900},
                new Product { ID = 1003,Name= "Desktop", Price = 800},
            };
            Dictionary<int, Product> productsDictionary = products.ToDictionary(x=>x.ID);
            foreach (var item in productsDictionary)
            {
                Console.WriteLine($"{item.Key} Name : {item.Value.Name} , Price {item.Value.Price}");
            }
            Console.ReadLine();
        }
    }
}
