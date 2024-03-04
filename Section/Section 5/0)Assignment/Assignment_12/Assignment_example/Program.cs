class Bank
{
    static void Main()
    {
        System.Console.WriteLine("********************************* " + Employee.OrganizationName + " *********************************");

        for(int index = 0;index < 10; index++)
        {
            string employeeNumber;

            switch (index)
            {
                case 0: employeeNumber = "\nFIRST EMPLOYEE:"; break;
                case 1: employeeNumber = "\nSECOND EMPLOYEE:"; break;
                case 2: employeeNumber = "\nTHIRD EMPLOYEE:"; break;
                case 3: employeeNumber = "\nFOURTH EMPLOYEE:"; break;
                case 4: employeeNumber = "\nFIFTH EMPLOYEE:"; break;
                case 5: employeeNumber = "\nSIXTH EMPLOYEE:"; break;
                case 6: employeeNumber = "\nSEVENTH EMPLOYEE:"; break;
                case 7: employeeNumber = "\nEIGHTH EMPLOYEE:"; break;
                case 8: employeeNumber = "\nNINTH EMPLOYEE:"; break;
                case 9: employeeNumber = "\nTENTH EMPLOYEE:"; break;
                default: employeeNumber = "\nOTHER EMPLOYEE:"; break;
            }
            System.Console.WriteLine(employeeNumber);
            Employee emp = new Employee();

            System.Console.Write("Employee ID: ");
            emp.EmployeeID = uint.Parse(System.Console.ReadLine());

            System.Console.Write("Employee Name: ");
            emp.EmployeeName = System.Console.ReadLine();

            System.Console.Write("Salary per Hour: ");
            emp.SalaryPerHour = uint.Parse(System.Console.ReadLine());

            System.Console.Write("No. of Working Hours: ");
            emp.NoOfWorkingHours = uint.Parse(System.Console.ReadLine());

            emp.NetSalary = emp.NoOfWorkingHours * emp.SalaryPerHour;

            System.Console.WriteLine("\nDETAILS OF " + employeeNumber);
            System.Console.WriteLine("1)Employee ID: " + emp.EmployeeID);
            System.Console.WriteLine("2)Employee Name: " + emp.EmployeeName);
            System.Console.WriteLine("3)Salary per Hour: " + emp.SalaryPerHour);
            System.Console.WriteLine("4)No. of Working Hours: " + emp.NoOfWorkingHours);
            System.Console.WriteLine("5)Net Salary: " + emp.NetSalary);
            System.Console.WriteLine("6)Type of Employee: " + Employee.TypeOfEmployee);
            System.Console.WriteLine("7)Department Name: " + emp.DepartmentName);
            
            
            
            System.Console.WriteLine("\n\n Do You want to continue to next employee\n If yes type Y\n Else type N");
            string choice = System.Console.ReadLine();

            if ((choice == "n" || choice == "N"))
            {
                break;
            }
            System.Console.WriteLine("<<<<<<--------------------->>>>>");
        }

        System.Console.WriteLine("Thank You");
        System.Console.ReadKey();

    }
}