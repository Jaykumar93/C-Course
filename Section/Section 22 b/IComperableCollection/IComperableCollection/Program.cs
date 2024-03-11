using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComperableCollection
{
    class Employee:IComparable
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job {  get; set; }

        public int CompareTo(object obj)
        {
           // Console.WriteLine(this.EmpId + " || " + ((Employee)obj).EmpId);
           Employee otherEmp = (Employee)obj;

            return this.EmpName.CompareTo(otherEmp.EmpName);
        }
    }
    class Program
    {
        
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpId=104,EmpName="Jay",Job="Engineer"},
                new Employee(){EmpId=105,EmpName="Kartik",Job="Designer"},
                new Employee(){EmpId=101,EmpName="Avinash",Job="Scientist"},
                new Employee(){EmpId=103,EmpName="Keval",Job="Sales"}
            };
            employees.Sort();
            foreach (var item in employees)
            {
                Console.WriteLine(item.EmpId + " || " + item.EmpName + " || " + item.Job);
            }

            Console.ReadKey(); 
        }
    }
}
