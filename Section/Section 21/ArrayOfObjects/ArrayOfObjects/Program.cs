using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;



namespace ArrayOfObjects
{
    internal class Program
    {
        static void Main()
        {

            //creating the objects
            Employee employee1 = new Employee() { EmpID = 1, EmployeeName = "Jay" };
            Employee employee2 = new Employee() { EmpID = 2, EmployeeName = "Kartik" };
            Employee employee3 = new Employee { EmpID = 3, EmployeeName = "Avinash" };

            //creating an array of objects
            Employee[] employeeArray = new Employee[] { employee1, employee2,employee3 };


            // Alternate Method
            Employee[] employeeArray2 = new Employee[] 
            { 
                new Employee() { EmpID = 11, EmployeeName = "AAAA" },
                new Employee() { EmpID = 22, EmployeeName = "BBBB" },
                new Employee() { EmpID = 33, EmployeeName = "CCCC" } 
            };


            // foreach loop for array of objects

            foreach (Employee employee in employeeArray)
            {
                Console.WriteLine(employee.EmpID + ", " + employee.EmployeeName);

            }

            Console.ReadKey();

        }
    }
}
