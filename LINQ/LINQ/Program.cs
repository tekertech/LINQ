using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

namespace LINQ
{

    class Program
    {
        static void Main(string[] args)
        {
            // ToArray(), ToList()
            int[] arrayNumbers = { 10, 20, 30, 40, 50, 60, 78};
            List<int> listNumbers = arrayNumbers.ToList();
            arrayNumbers = listNumbers.ToArray();

            List<Product> products = new List<Product>()
            {
                new Product(){ ID = 1, Name = "A", Price = 10},
                new Product(){ ID = 2, Name = "B", Price = 20},
                new Product(){ ID = 3, Name = "C", Price = 30}
            };

            // (ToDictionary)
            Dictionary<int, Product> keyValuePairs = products.ToDictionary(x=> x.ID);

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine("Key :" + item.Key + " Value : " + item.Value.ID);
            }


            Console.ReadLine();
        }
    }
}
