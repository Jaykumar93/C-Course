using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    class Employee:ICloneable
    {
        public string EmployeeName { get; set; }
        public string Role { get; set; }

        public object Clone()
        {
            Employee new_one = new Employee() { EmployeeName = this.EmployeeName, Role = this.Role };

            return new_one;
        }
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
            Console.WriteLine("Original Array:\n");

            foreach (Employee employee in emp)
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

            Employee[] EmployeeDeepCopy = new Employee[emp.Length];

            for (int count = 0; count < emp.Length; count++)
            {
                var result = (Employee)emp[count].Clone();
                EmployeeDeepCopy[count] = result;
            }

            EmployeeDeepCopy[0].EmployeeName = "Ram";


            Console.WriteLine("\n\nDeep Clone after making change in the cloned array :\n");
            foreach (Employee employee in EmployeeDeepCopy)
            {
                if (!(emp is null))
                {
                    Console.WriteLine(employee.EmployeeName + ", " + employee.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            Console.WriteLine("\n--------------------------------------------------------------------------------\n");


            emp[0].EmployeeName = "Sham";

            Console.WriteLine("Original Array:\n");

            foreach (Employee employee in emp)
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

            Console.WriteLine("\n\nDeep Clone after making change in the original array array :\n");
            foreach (Employee employee in EmployeeDeepCopy)
            {
                if (!(emp is null))
                {
                    Console.WriteLine(employee.EmployeeName + ", " + employee.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            Console.ReadKey();
        }
    }
}