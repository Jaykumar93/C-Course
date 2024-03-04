class Program
{
    static void Main()
    {

        //parent
        Employee employee1 = new Employee(1,"jay","pune");

        /*
        employee1.EmpID = 1;
        employee1.EmpName = "jay";
        employee1.Location = "Pune";
        */

        System.Console.WriteLine("Object of Parent Class");
        System.Console.WriteLine(employee1.EmpID);
        System.Console.WriteLine(employee1.EmpName);
        System.Console.WriteLine(employee1.Location);


        //Child 1
        Manager manager1 = new Manager(212,"12332","12323","234242");

        /*
        manager1.EmpID =212 ;
        manager1.EmpName = "gfgfg";
        manager1.Location = "aetrge";
        manager1.DepartmentName = "Account";
        */

        System.Console.WriteLine("Object of Child Class Manager");
        System.Console.WriteLine(manager1.EmpID);
        System.Console.WriteLine(manager1.EmpName);
        System.Console.WriteLine(manager1.Location);
        System.Console.WriteLine(manager1.DepartmentName);
        System.Console.WriteLine(manager1.GetTotalSalesOfTheYear());

        //Child 2
        SalesMan salesMan1 = new SalesMan(23,"dfghjgfsdb", "sdfasfd", "Hyderbad");
        /*
        salesMan1.EmpID = 23;
        salesMan1.EmpName = "dfghjgfsdb";
        salesMan1.Location = "sdfasfd";
        salesMan1.Region = "Hyderbad";
        */

        System.Console.WriteLine("Object of Child Class Sales");
        System.Console.WriteLine(salesMan1.EmpID);
        System.Console.WriteLine(salesMan1.EmpName);
        System.Console.WriteLine(salesMan1.Location);
        System.Console.WriteLine(salesMan1.Region);
        System.Console.WriteLine(salesMan1.GetSalesOfTheCurrentMonth());

        

        System.Console.ReadKey();
    }
    
}