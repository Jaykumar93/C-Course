using System;
using System.Collections.Generic;
using Company;

namespace ManyToOneExample
{
    class Program
    {
        static void Main()
        {
            //Three employees in same department
            Employee employee1 = new Employee() { EmployeeID = 1, EmployeeName = "Scott", Email = "scott@gmail.com" };
            Employee employee2 = new Employee() { EmployeeID = 2, EmployeeName = "Allen", Email = "allen@gmail.com" };
            Employee employee3 = new Employee() { EmployeeID = 3, EmployeeName = "Smith", Email = "smith@gmail.com" };

            //create object of Department class
            Department department = new Department() { DepartmentID = 10, DepartmentName = "Accounting" };
            employee1.dept = department;
            employee2.dept = department;
            employee3.dept = department;

            //print
            Console.WriteLine("\nFIRST EMPLOYEE:");
            Console.Write("\nEmployee ID: " + employee1.EmployeeID);
            Console.Write("\nEmployee Name: " + employee1.EmployeeName);
            Console.Write("\nEmail: " + employee1.Email);
            Console.Write("\nDepartment ID: " + employee1.dept.DepartmentID);
            Console.Write("\nDepartment Name: " + employee1.dept.DepartmentName);

            Console.WriteLine("\n\n-----------------------------------------------------------------------");


            Console.WriteLine("\n\nSECOND EMPLOYEE:");
            Console.Write("\nEmployee ID: " + employee2.EmployeeID);
            Console.Write("\nEmployee Name: " + employee2.EmployeeName);
            Console.Write("\nEmail: " + employee2.Email);
            Console.Write("\nDepartment ID: " + employee2.dept.DepartmentID);
            Console.Write("\nDepartment Name: " + employee2.dept.DepartmentName);

            Console.WriteLine("\n\n-----------------------------------------------------------------------");

            Console.WriteLine("\n\nTHIRD EMPLOYEE:");
            Console.Write("\nEmployee ID: " + employee3.EmployeeID);
            Console.Write("\nEmployee Name: " + employee3.EmployeeName);
            Console.Write("\nEmail: " + employee3.Email);
            Console.Write("\nDepartment ID: " + employee3.dept.DepartmentID);
            Console.Write("\nDepartment Name: " + employee3.dept.DepartmentName);

            Console.ReadKey();
        }
    }
}
