using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{ // This is the Customer class, representing a customer who may place orders.
    public class Customer
    {
        public int CustomerID { get; set; } // Unique identifier for a customer
        public string FirstName { get; set; } // First name of the customer
        public string LastName { get; set; } // Last name of the customer
        public string Country { get; set; } // Country where the customer is located
    }


    // This is the Order class, representing an order placed by a customer.
    public class Order
    {
        public int OrderID { get; set; } // Unique identifier for an order
        public int CustomerID { get; set; } // Identifier for the customer who placed the order
        public DateTime OrderDate { get; set; } // Date on which the order was placed
        public DateTime? ShippedDate { get; set; } // Date on which the order was shipped, nullable
    }


    // This is the Product class, representing a product that may be ordered.
    public class Product
    {
        public int ProductID { get; set; } // Unique identifier for a product
        public string ProductName { get; set; } // Name of the product
        public decimal UnitPrice { get; set; } // Price of a single unit of the product
    }


    // This is the OrderDetail class, representing a line item in an order.
    public class OrderDetail
    {
        public int OrderDetailID { get; set; } // Unique identifier for an order detail
        public int OrderID { get; set; } // Identifier for the order to which the detail belongs
        public int ProductID { get; set; } // Identifier for the product in the order detail
        public int Quantity { get; set; } // Number of units of the product ordered
        public decimal Discount { get; set; } // Discount applied to the product in the order detail
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // define a list of customers
            List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerID = 1, FirstName = "John", LastName = "Doe", Country = "USA" },
            new Customer { CustomerID = 2, FirstName = "Jane", LastName = "Doe", Country = "USA" },
            new Customer { CustomerID = 3, FirstName = "Alice", LastName = "Smith", Country = "Canada" },
            new Customer { CustomerID = 4, FirstName = "Bob", LastName = "Smith", Country = "Canada" },
            new Customer { CustomerID = 5, FirstName = "Charlie", LastName = "Brown", Country = "USA" }
        };

            // Create some sample products
            List<Product> products = new List<Product>
        {
            new Product { ProductID = 1, ProductName = "Chai", UnitPrice = 18.00M },
            new Product { ProductID = 2, ProductName = "Chang", UnitPrice = 19.00M },
            new Product { ProductID = 3, ProductName = "Aniseed Syrup", UnitPrice = 10.00M },
            new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", UnitPrice = 22.00M },
            new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", UnitPrice = 21.35M },
            new Product { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", UnitPrice = 25.00M },
            new Product { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", UnitPrice = 30.00M },
            new Product { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", UnitPrice = 40.00M },
            new Product { ProductID = 9, ProductName = "Mishi Kobe Niku", UnitPrice = 97.00M },
            new Product { ProductID = 10, ProductName = "Ikura", UnitPrice = 31.00M },
            new Product { ProductID = 11, ProductName = "Queso Cabrales", UnitPrice = 21.00M },
            new Product { ProductID = 12, ProductName = "Queso Manchego La Pastora", UnitPrice = 38.00M },
            new Product { ProductID = 13, ProductName = "Konbu", UnitPrice = 6.00M },
            new Product { ProductID = 14, ProductName = "Tofu", UnitPrice = 23.25M },
            new Product { ProductID = 15, ProductName = "Genen Shouyu", UnitPrice = 15.50M }
        };

            // define a list of orders
            List<Order> orders = new List<Order>
            {
                new Order { OrderID = 1, CustomerID = 1, OrderDate = new DateTime(2022, 1, 1), ShippedDate = new DateTime(2022, 1, 10) },
                new Order { OrderID = 2, CustomerID = 1, OrderDate = new DateTime(2022, 2, 1), ShippedDate = new DateTime(2022, 2, 10) },
                new Order { OrderID = 3, CustomerID = 2, OrderDate = new DateTime(2022, 3, 1), ShippedDate = new DateTime(2022, 3, 10) },
                new Order { OrderID = 4, CustomerID = 3, OrderDate = new DateTime(2022, 4, 1), ShippedDate = new DateTime(2022, 4, 10) },
                new Order { OrderID = 5, CustomerID = 4, OrderDate = new DateTime(2022, 5, 1), ShippedDate = new DateTime(2022, 5, 10) },
                new Order { OrderID = 6, CustomerID = 5, OrderDate = new DateTime(2022, 6, 1), ShippedDate = new DateTime(2022, 6, 10) },
                new Order { OrderID = 7, CustomerID = 1, OrderDate = new DateTime(2022, 7, 1), ShippedDate = new DateTime(2022, 7, 10) },
                new Order { OrderID = 8, CustomerID = 2, OrderDate = new DateTime(2022, 8, 1), ShippedDate = new DateTime(2022, 8, 10) },
                new Order { OrderID = 9, CustomerID = 3, OrderDate = new DateTime(2022, 9, 1), ShippedDate = new DateTime(2022, 9, 10) },
                new Order {OrderID = 10, CustomerID = 4, OrderDate = new DateTime(2022, 10, 1),ShippedDate = new DateTime(2022, 10, 10) }
                };

            // define a list of order details
            List<OrderDetail> orderDetails = new List<OrderDetail>()
            {
                new OrderDetail() { OrderDetailID = 1, OrderID = 1, ProductID = 1, Quantity = 5, Discount = 0.1m },
                new OrderDetail() { OrderDetailID = 2, OrderID = 1, ProductID = 2, Quantity = 3, Discount = 0m },
                new OrderDetail() { OrderDetailID = 3, OrderID = 2, ProductID = 3, Quantity = 2, Discount = 0.05m },
                new OrderDetail() { OrderDetailID = 4, OrderID = 2, ProductID = 4, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 5, OrderID = 3, ProductID = 5, Quantity = 4, Discount = 0m },
                new OrderDetail() { OrderDetailID = 6, OrderID = 4, ProductID = 6, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 7, OrderID = 4, ProductID = 7, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 8, OrderID = 5, ProductID = 8, Quantity = 3, Discount = 0m },
                new OrderDetail() { OrderDetailID = 9, OrderID = 5, ProductID = 9, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 10, OrderID = 5, ProductID = 10, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 11, OrderID = 6, ProductID = 1, Quantity = 4, Discount = 0m },
                new OrderDetail() { OrderDetailID = 12, OrderID = 7, ProductID = 2, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 13, OrderID = 7, ProductID = 3, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 14, OrderID = 7, ProductID = 4, Quantity = 3, Discount = 0.1m },
                new OrderDetail() { OrderDetailID = 15, OrderID = 8, ProductID = 5, Quantity = 7, Discount = 0m },
                new OrderDetail() { OrderDetailID = 16, OrderID = 8, ProductID = 6, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 17, OrderID = 9, ProductID = 7, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 18, OrderID = 10, ProductID = 8, Quantity = 3, Discount = 0m },
                new OrderDetail() { OrderDetailID = 19, OrderID = 10, ProductID = 9, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 20, OrderID = 10, ProductID = 10, Quantity = 4, Discount = 0m }
            };


            //Query 1: All customers in alphabetical order by last name
            List<Customer> SortedByLast = customers.OrderBy(Name =>Name.LastName).ToList();

            foreach (var item in SortedByLast)
            {
                Console.WriteLine(item.CustomerID + " || " + item.FirstName + " || " + item.LastName + " || " + item.Country);
            }

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            // Query 2: All products in order of unit price, from highest to lowest


            List<Product> ProductUnitPrice = products.OrderBy(product => product.UnitPrice).ToList();

            foreach (var item in ProductUnitPrice)
            {
                Console.WriteLine(item.ProductID + " || " + item.ProductName + " || " + item.UnitPrice  );
            }


            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");


            //Query 3: All orders shipped in October 2021

           
            List<Order> OrderByShipped = orders.Where(order => order.ShippedDate >= new DateTime(2021,10,1) && order.ShippedDate <= new DateTime(2021, 10, 1)).ToList();

            foreach (var item in OrderByShipped) 
            {
                Console.WriteLine(item.OrderID + " || " + item.OrderDate + " || " + item.OrderDate + " || " + item.ShippedDate);
            }

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");


            //Query 4: All orders shipped to customers in the USA

            var query = from customer in customers
                        join order in orders
                        on customer.CustomerID equals order.CustomerID
                        where customer.Country == "USA"
                        select order;

            // Display the results
            foreach (var item in query)
            {
                Console.WriteLine(item.OrderID + " || " + item.OrderDate + " || " + item.OrderDate + " || " + item.ShippedDate);
            }
            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            //Query 5: All products that were ordered at least once, along with the total quantity ordered and the total revenue generated by each product


            
              var query1 = (from Product in products
                                join OrderDetail in orderDetails
                                on Product.ProductID equals OrderDetail.ProductID
                                select new { OrderDetail.ProductID, OrderDetail.Quantity, Product.UnitPrice }).ToList();


            var totalRevenue = query1.GroupBy(od => od.ProductID)
                               .Select(g => new
                               {
                                    ProductID = g.Key,
                                    TotalQuantity = g.Sum(x => x.Quantity),
                                    TotalRevenue = g.Sum(x => x.Quantity * x.UnitPrice)
                                }).ToList();
            


            // Display the results
            foreach (var orderDetail in totalRevenue)
            {
                Console.WriteLine($"Product ID:{orderDetail.ProductID} , Quantity: {orderDetail.TotalQuantity}, Revenue:{orderDetail.TotalRevenue}");
            }

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            //Query 6: The top 5 customers by the total amount of money they have spent, along with the number of orders they have placed and the average order amount


            var query6part1 = from customer in customers
                          join order in orders on customer.CustomerID equals order.CustomerID
                          join orderDetail in orderDetails on order.OrderID equals orderDetail.OrderID
                          join product in products on orderDetail.ProductID equals product.ProductID
                          select new
                          {
                              CustomerID = customer.CustomerID,
                              ProductID = product.ProductID,
                              ProductName = product.ProductName,
                              ProductPrice = product.UnitPrice,
                              OrderId = orderDetail.OrderID,
                              Quantity = orderDetail.Quantity,
                              Discount = orderDetail.Discount
                          };
            var query6 = query6part1.GroupBy(g => g.CustomerID)
                                .Select(g => new
                                {
                                    CustomerID = g.Key,
                                    TotalOrder = g.GroupBy(x=>x.OrderId).Count(),
                                    TotalAmount = g.Sum(x =>( x.ProductPrice * x.Quantity)-x.Discount),
                                    AverageByOrder = (g.Sum(x => (x.ProductPrice * x.Quantity) - x.Discount)) / g.GroupBy(x => x.OrderId).Count(),

                                }).ToList().OrderByDescending(x=>x.TotalAmount).Take(4);



            foreach (var Details in query6)
            {
                Console.WriteLine($"Customers ID:{Details.CustomerID} || Total Order: {Details.TotalOrder} || Total Amount:{Details.TotalAmount} || AverageCostByOrder:{Details.AverageByOrder}");
            }

            //foreach (var group in query2)
            //{
            //    Console.WriteLine($"CustomerID {group.Key}:");
            //    foreach (var customer in group)
            //    {
            //        Console.WriteLine($"--{customer.ProductID}--{customer.OrderId}--{customer.Quantity}--{customer.ProductPrice}");
            //    }
            //    Console.WriteLine();
            //}

            //Query 7: The most popular product by the number of times it has been ordered

            var query7 = (from OrderDetail in orderDetails
                          join Product in products
                          on OrderDetail.ProductID equals Product.ProductID
                          select new
                          {
                              productID = Product.ProductID,
                              productName = Product.ProductName,
                              quantity = OrderDetail.Quantity,
                              orderID = OrderDetail.OrderID
                          }).GroupBy(x => x.productID)
                          .Select(g=> new
                          {
                              ProductName = g.Key,
                              Quantity = g.Sum(x=>x.quantity)
                          }).OrderByDescending(Product=>Product.Quantity);

            

            
                foreach (var item in query7)
                {
                    Console.WriteLine($"  Product Name: {item.ProductName}, Quantity: {item.Quantity}");
                }
            


            Console.ReadKey();
        }
    }
}
