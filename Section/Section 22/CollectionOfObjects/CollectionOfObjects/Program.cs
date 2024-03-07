using ECommerce;
using System;
using System.Collections.Generic;

namespace CollectionOfObjects
{
    internal class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>();

            string choice;
            do
            {
                Console.Write("\nEnter Product Id:");
                int product_Id = int.Parse(Console.ReadLine());
                Console.Write("\nEnter Product Name:");
                string product_Name = Console.ReadLine();
                Console.Write("\nEnter Product Price:");
                double product_Price = double.Parse(Console.ReadLine());
                Console.Write("\nEnter Product Date Of Manufacturing (YYYY-MM-DD):");
                DateTime dateofmanufacturing = DateTime.Parse(Console.ReadLine());


                // Creating a new product object 
                Product product = new Product()
                {
                    ProductId = product_Id,
                    ProductName = product_Name,
                    Price = product_Price,
                    DateOfManufacture = dateofmanufacturing
                };

                // inserting the object creating into the collection of the objects 
                products.Add(product);


                Console.WriteLine("Product Added.\n");
                Console.WriteLine("Do you want to continue to next product? (Yes/No)");
                choice = Console.ReadLine();

            } while (choice != "No" && choice != "no" && choice != "NO"); 

            foreach(Product product in products) 
            {
                Console.WriteLine("Product Id:" + product.ProductId);
                Console.WriteLine("Product Name:" + product.ProductName);
                Console.WriteLine("Product Price:" + product.Price);
                Console.WriteLine("Product Date Of Manufacturing:" + product.DateOfManufacture);
            }

            Console.ReadKey();


        }
    }
}
