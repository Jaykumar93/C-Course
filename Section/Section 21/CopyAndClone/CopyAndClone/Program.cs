using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CopyAndClone
{
    class Employee
    {

        /// <summary>
        /// Both the methods perform shallow copying that is both the array that is new and only both store the reference of the each object(that is stored in the heap)
       
        /// so if the changes are made to one array it will be changed in reference and hence the changes will be showned in both the array
        /// </summary>
        public string EmployeeName { get; set; }
        public string Role { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Employee[] emp = new Employee[]
            {
                new Employee() { EmployeeName = "Jay", Role = "Developer" },
                new Employee() { EmployeeName = "Avinash", Role = "Designer" },
                new Employee() { EmployeeName = "Kartik", Role = "Doctor" }
            };

            foreach (Employee employee in emp)
            {
                Console.WriteLine(employee.EmployeeName + ", " + employee.Role);
            }
            Console.WriteLine("");

            //Copy
            Console.WriteLine("\n\nCopy\n");

            Employee[] HighlyPaidEmployees = new Employee[5];

            emp.CopyTo(HighlyPaidEmployees, 1);

            foreach (Employee employee in HighlyPaidEmployees)
            {
                if (!(employee is null)) 
                {
                    Console.WriteLine(employee.EmployeeName + ", " + employee.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }
            Console.WriteLine("");


            //Clone

            Console.WriteLine("\n\nCLONE\n");
            Employee[] highlyPaidEmployee2 = (Employee[])emp.Clone();

            foreach(Employee employee in highlyPaidEmployee2) 
            {
                if (!(employee is null))
                {
                    Console.WriteLine(employee.EmployeeName + ", " + employee.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            Console.ReadLine();
        }
    }
}