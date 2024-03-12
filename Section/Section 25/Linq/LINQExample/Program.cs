using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }

        public int Salary {  get; set; }
    }

    class Person
    {
        public string Name { get; set; }
        public string PersonName { get; internal set; }
    }

    class Program
    {
        public static string Job { get; private set; }

        static void Main()
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", City = "Boston",Salary=122442 },
                new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", City = "New York",Salary=645456  },
                new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", City = "Tokyo",Salary=567876  },
                new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", City = "Tokyo",Salary=234556  },
                new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", City = "New York" ,Salary=478456 },
                new Employee() { EmpID = 106, EmpName = "jam", Job = "Manager", City = "New" ,Salary=9876543 }
            };

          
            var result = employees.Where(emp => emp.Job == "Manager");

            foreach(Employee emp in result)
            {
                Console.WriteLine(emp.EmpID + " || " + emp.EmpName + " || " + emp.Job);
            }
            /*
            result = employees.Where(emp => emp.City == "Boston");

            foreach (Employee emp in result)
            {
                Console.WriteLine(emp.EmpID + " || " + emp.EmpName + " || " + emp.Job);
            }
            */
            Console.WriteLine("\n\n");
            
            IOrderedEnumerable<Employee> sortedEmployee = employees.OrderBy(emp => emp.Salary);

            foreach (Employee emp in sortedEmployee)
            {
                Console.WriteLine(emp.EmpID + " || " + emp.EmpName + " || " + emp.Job+ " || " + emp.Salary);
            }


            Console.WriteLine("\n\n");


            //desending form
            /*
              IOrderedEnumerable<Employee> sortedEmployeeDesc = employees.OrderByDescending(emp => emp.Salary);

            foreach (Employee emp in sortedEmployeeDesc)
            {
                Console.WriteLine(emp.EmpID + " || " + emp.EmpName + " || " + emp.Job + " || " + emp.Salary);
            }*/

            //then by command
            IOrderedEnumerable<Employee> sortedEmployeeAlpha = employees.OrderBy(emp => emp.Job).ThenBy(emp => emp.EmpName);

            foreach (Employee emp in sortedEmployeeAlpha)
            {
                Console.WriteLine(emp.EmpID + " || " + emp.EmpName + " || " + emp.Job + " || " + emp.City + " || " + emp.Salary);
            }

            //where
            List<Employee> filteredEmployees = employees.Where(emp => emp.Job == "Manager").ToList();
            Console.WriteLine(filteredEmployees[0].EmpID + "  " + filteredEmployees[0].EmpName);

            Console.WriteLine("\n++++++++++++++++++++++\n");

            //first
            Employee firstManager = employees.First(emp => emp.Job == "Manager");
            Console.WriteLine(firstManager.EmpID + "  " + firstManager.EmpName);


            //firstOrDefault
            Employee firstManager2 = employees.FirstOrDefault(emp => emp.Job == "Clerk");
            if (firstManager2 != null)
            {
                Console.WriteLine(firstManager2.EmpID + "  " + firstManager2.EmpName);
            }
            else
            {
                Console.WriteLine("no such values");
            }
            Console.WriteLine("\n++++++++++++++++++++++\n");

            //last
            Employee LastManager = employees.Last(emp => emp.Job == "Manager");
            Console.WriteLine(LastManager.EmpID + "  " + LastManager.EmpName);


            //firstOrDefault
            Employee LastManager2 = employees.LastOrDefault(emp => emp.Job == "Clerk");
            if (LastManager2 != null)
            {
                Console.WriteLine(LastManager2.EmpID + "  " + LastManager2.EmpName);
            }
            else
            {
                Console.WriteLine("no such values");
            }


            Console.WriteLine("\n++++++++++++++++++++++\n");

            //elementAt
            Employee MiddleManager = employees.Where(emp => emp.Job == "Manager").ElementAt(1);
            Console.WriteLine(MiddleManager.EmpID + "  " + MiddleManager.EmpName);


            //ElementAtDefault
            Employee MiddleManager2 = employees.Where(emp => emp.Job == "Manager").ElementAtOrDefault(4);
            if (LastManager2 != null)
            {
                Console.WriteLine(LastManager2.EmpID + "  " + LastManager2.EmpName);
            }
            else
            {
                Console.WriteLine("no such values");
            }


            // Single 
            //works same as first only the difference it output result cant have more than one values in case of single 
            // require only one maching element 

            Console.WriteLine("\n++++++++++++++++++++++\n");

            //Select

            IEnumerable<Person> SelectOut = employees.Select(emp => new Person());

            foreach(Person item in SelectOut)
            {
                Console.WriteLine(item);
            }

            List<Person> SelectResult = employees.Select(emp => new Person() { Name = emp.EmpName}).ToList();

            foreach (Person item in SelectResult)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(employees.Min(emp =>emp.Salary));
            Console.WriteLine(employees.Max(emp => emp.Salary));
            Console.WriteLine(employees.Average(emp => emp.Salary));
            Console.WriteLine(employees.Count());




            Console.ReadKey();
        }
    }
}
