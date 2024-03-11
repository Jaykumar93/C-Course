using System;

namespace TupleExample
{
    class Sample
    {
        public Tuple<string, int> GetPersonDetails()
        {
            //create a new Tuple that stores person name and age
            Tuple<string, int> tuple = new Tuple<string, int>("Scott", 20);

            return tuple;
        }
    }
    // Value Tuples 
    public class Customer
    {
        public (int customerID, string customerName, string email) GetCustomerDetails()
        {
            return (101, "Scott", "scott@gmail.com");
        }
    }
    class Program
    {
        static void Min()
        {
            Sample s = new Sample();
            Tuple<string, int> person = s.GetPersonDetails();

            //access values from tuple
            Console.WriteLine(person.Item1); //Scott
            Console.WriteLine(person.Item2); //20
            


            // CALLING VALUE TUPLES 
            Customer customer = new Customer();

            //get details
            (int customerID, string customerName, string email) cust = customer.GetCustomerDetails();

            Console.WriteLine(cust.customerID);
            Console.WriteLine(cust.customerName);
            Console.WriteLine(cust.email);


            // Deconstructing the tuple 
            (int customerID, string customerName, string email) = customer.GetCustomerDetails();


            // use underscore to discard the value or to not insert the values 

            (int customer12ID, _, string em12ail) = customer.GetCustomerDetails();

            Console.ReadKey();

        }
    }
}
